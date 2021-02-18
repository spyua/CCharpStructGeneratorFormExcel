using ClosedXML.Excel;
using Core.Help;
using System;
using System.Linq;
using System.Text;

namespace StructGenerator.Format
{
    public class StructFile : ExcelFile, IFile
    {
        private string _decodeStr;

        public StructFile(ExcelFile fileInfo)
        {
            StarSheet = fileInfo.StarSheet;
            StarReadRaw = fileInfo.StarReadRaw;
            StarReadCloumn = fileInfo.StarReadCloumn;
            SourcePath = fileInfo.SourcePath;
            OutFileName = fileInfo.OutFileName;
            ExportPath = fileInfo.ExportPath;
        }

        public string Decode()
        {
            var workbook = new XLWorkbook(SourcePath);

            var decodeStr = new StringBuilder();

            decodeStr.Append("using System;\r\n");
            decodeStr.Append("using System.Runtime.InteropServices;\r\n");
            decodeStr.Append("namespace MsgStruct\r\n{\r\n");
            decodeStr.Append($"\tpublic class Msg_{OutFileName}\t\n" + "{");

            for (int i = StarSheet; i <= workbook.Worksheets.Count; i++)
            {
                var rows = workbook.Worksheet(i).RangeUsed().RowsUsed().Skip(StarReadRaw);
                decodeStr.Append("[Serializable]\r\n[StructLayout(LayoutKind.Sequential, Pack = 1)]\r\n");
                decodeStr.Append("public class " + "Msg_" + workbook.Worksheet(i).Name + " { \r\n");


                foreach (var row in rows)
                {
                    var rowNumber = row.RowNumber();

                    var item = row.Cell(StarReadCloumn).GetString();
                    item = ClearInvaildSymbol(item);

                    var dataType = row.Cell(StarReadCloumn + 1).GetString();
                    var length = row.Cell(StarReadCloumn + 2).GetString();
                    var des = row.Cell(StarReadCloumn + 4).GetString();

                    string type = GetTypeCode(dataType);
                    {
                        decodeStr.Append(GetAttr(type, Convert.ToInt32(length)) + "\r\n");
                        decodeStr.Append($"    public {type}  {item}");
                        decodeStr.Append(";\r\n");
                    }
                }
                decodeStr.Append("\r\n}\r\n");
            }
            decodeStr.Append("\r\n}\r\n}");
            
            _decodeStr = decodeStr.ToString();

            return _decodeStr;
        }

        public bool GenFile()
        {
            if (_decodeStr == null)
                return false;

            var genOK = FileOpHelper.Instance.WriteToFile(_decodeStr, ExportPath + OutFileName + ".cs");

            return genOK;
        }

        private string ClearInvaildSymbol(string txt)
        {
            txt = txt.Replace(" ", "");
            txt = txt.Replace("-", "");
            txt = txt.Replace("(", "");
            txt = txt.Replace(")", "");
            txt = txt.Replace("-", "");
            txt = txt.Replace("~", "");
            txt = txt.Replace(".", "");

            return txt;
        }

        private string GetTypeCode(string type)
        {
            string rtn = "";
            type = type.ToLower();
            if (type.StartsWith("a")) type = "c";
            switch (type)
            {
                case "il":
                case "dw":
                    rtn = "int";
                    break;
                case "r":
                case "f":
                    rtn = "float";
                    break;
                case "i":
                case "w":
                    rtn = "short";
                    break;
                case "c":
                    rtn = "byte[]";
                    break;
                case "n":
                    rtn = "byte[]";
                    break;
            }
            return rtn;
        }

        public string GetAttr(string type, int strLen = -1)
        {
            string rtn = "";
            switch (type)
            {
                case "short":
                    rtn = $"    [MarshalAs(UnmanagedType.I2)]";
                    break;
                case "int":
                    rtn = $"    [MarshalAs(UnmanagedType.I4)]";
                    break;
                case "float":
                    rtn = $"    [MarshalAs(UnmanagedType.R4)]";
                    break;
                case "byte[]":
                    rtn = $"    [MarshalAs(UnmanagedType.ByValArray, SizeConst = {strLen})]";
                    break;
            }
            return rtn;
        }
    }
}
