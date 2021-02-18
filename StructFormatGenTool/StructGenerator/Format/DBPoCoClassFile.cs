using StructGenerator;

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
            throw new System.NotImplementedException();
        }

        public bool GenFile()
        {
            throw new System.NotImplementedException();
        }
    }
}
