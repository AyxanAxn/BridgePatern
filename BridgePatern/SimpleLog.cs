using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern
{
    class SimpleLog : ILog
    {
        
     
        public IWriter writer { get ; set ; }

        public SimpleLog(IWriter Writer)
        {
            writer = Writer;
        }
        public void LogError(string data)
        {
            writer.writeSomething($"{data}");
        }

        public void LogInfo(string data)
        {
            writer.writeSomething($"{data}");
        }

        public void LogWarring(string data)
        {
            writer.writeSomething($"{data}");
        }
    }
}
