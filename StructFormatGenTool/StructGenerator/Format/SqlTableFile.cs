using ClosedXML.Excel;
using Core.Help;
using System.Linq;
using System.Text;

namespace StructGenerator.Format
{
    class SQLTableFile : ExcelFile, IFile
    {
        private string _decodeStr;

        public SQLTableFile(ExcelFile fileInfo)
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
            var decodeStr = new StringBuilder();

            var workbook = new XLWorkbook(SourcePath);
            for (int k = StarSheet; k <= workbook.Worksheets.Count; k++)
            {
                var rows = workbook.Worksheet(k).RangeUsed().RowsUsed().Skip(StarReadRaw);
                decodeStr.Append($"Drop Table TBL_{workbook.Worksheet(k).Name} ;Create Table TBL_{workbook.Worksheet(k).Name} (\r\n");

                decodeStr.Append($"    Create_DateTime datetime ,\r\n");

                foreach (var row in rows)
                {

                    var fieldName = row.Cell(StarReadCloumn).GetString();
                    var dataType = row.Cell(StarReadCloumn + 1).GetString();
                    var length = row.Cell(StarReadCloumn + 2).GetString();

                    fieldName = BeautifySqlFieldName(fieldName);
                    string type = GetSqlTypeCode(dataType);

                    if (type == "varchar")
                        decodeStr.Append($"    {fieldName} {type} ({length}) ,\r\n");
                    else
                        decodeStr.Append($"    {fieldName} {type} ,\r\n");
                }
                decodeStr.Append("    primary key(Create_DateTime)\r\n");

                decodeStr.Append(");\r\n");
            }

            _decodeStr = decodeStr.ToString();

            return decodeStr.ToString();
        }

        public bool GenFile()
        {
            if (_decodeStr == null)
                return false;

            var genOK = FileOpHelper.Instance.WriteToFile(_decodeStr, ExportPath + OutFileName+".sql");

            return genOK;
        }

        private string GetSqlTypeCode(string type)
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
                    rtn = "smallint";
                    break;
                case "c":
                    rtn = "varchar";
                    break;
            }
            return rtn;
        }

        private string BeautifySqlFieldName(string fieldName)
        {
            return fieldName.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace("-", "").Replace("~", "");
        }
    }
}
