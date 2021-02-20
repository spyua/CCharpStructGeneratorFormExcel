using Core.Help;
using Generator.Format.DBPoCoGen;
using StructGenerator;
using System.Configuration;
using System.Data.SqlClient;

namespace Generator.Format
{
    public class DBPoCoClassFile : FileInfo, IFile
    {

        private string _decodeStr;

        public DBPoCoClassFile(FileInfo fileInfo)
        { 
            OutFileName = fileInfo.OutFileName;
            ExportPath = fileInfo.ExportPath;
        }

        public string Decode()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBLink"].ConnectionString;
            using (var connection = new SqlConnection(connStr))
            {

                return _decodeStr = connection.GenerateAllTables(generatorBehavior: GeneratorBehavior.DbHander);
            }
        }

        public bool GenFile()
        {
            if (_decodeStr == null)
                return false;

            var genOK = FileOpHelper.Instance.WriteToFile(_decodeStr, ExportPath + OutFileName + ".cs");
    
            return genOK;
        }
    }
}
