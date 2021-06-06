using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern
{
    class FileHelper : IWriter
    {
        public string FileName { get; set; }
        public FileHelper(string fileName)
        {
            FileName = fileName;
        }
        public void writeSomething(string data)
        {
            using (FileStream fs=new FileStream(FileName,FileMode.Append))
            {
                using (StreamWriter sw=new StreamWriter(fs,Encoding.UTF8))
                {
                    sw.WriteLine(data);
                }
            }
        }
    }
}
