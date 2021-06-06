using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern
{
    interface ILog
    {
        IWriter writer { get; set; }
        void LogInfo(string data);
        void LogError(string data);
        void LogWarring(string data);
    }
}
