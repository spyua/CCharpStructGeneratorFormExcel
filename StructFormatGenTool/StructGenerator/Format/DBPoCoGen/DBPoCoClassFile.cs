using Core.Help;
using Generator.Format.DBPoCoGen;
using StructGenerator;
using System;
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

            if (string.IsNullOrEmpty(_decodeStr))
                throw new ArgumentNullException("Decod Faile. Code Str is empty.");

            try
            {
                FileOpHelper.Instance.WriteToFile(_decodeStr, ExportPath + OutFileName + ".cs");
                return true;
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

        }
    }
}
