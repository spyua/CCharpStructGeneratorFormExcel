using System;
using System.IO;
using System.Text;

namespace Core.Help
{
    public class FileOpHelper
    {
        private static class SingletonHolder
        {
            static SingletonHolder() { }
            internal static readonly FileOpHelper INSTANCE = new FileOpHelper();
        }
        public static FileOpHelper Instance { get { return SingletonHolder.INSTANCE; } }

        public bool IsFileLocked(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                s.Close();
                
            }
            catch (IOException)
            {
                //The file is unavailable
                return true;
            }

            return false;          
        }

        public bool WriteToFile(string content, string path)
        {
            try
            {

                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(content);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
