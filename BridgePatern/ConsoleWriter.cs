using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern
{
    class ConsoleWriter : IWriter
    {
        public void writeSomething(string data)
        {
            Console.WriteLine(data);
        }
    }
}
