using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern
{
    class DetailedLog : ILog
    {
        private string Detailed(string data1, string data2) {
            StringBuilder str = new StringBuilder();
            str.Append($"Type {data1}");
            str.Append($"Info {data2}");
            return str.ToString();
        }
        public IWriter writer { get; set; }
        public DetailedLog(IWriter Writer)
        {
            writer = Writer;
        }
        public void LogError(string data)
        {
            writer.writeSomething(Detailed("Err", $"{data}"));
        }

        public void LogInfo(string data)
        {
            writer.writeSomething(Detailed("Info", $"{data}")); 
           
        }

        public void LogWarring(string data)
        {
           
            writer.writeSomething(Detailed("Warring", $"{data}")); 
        }
    }
}
