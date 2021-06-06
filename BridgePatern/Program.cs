using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriter cw = new ConsoleWriter();
            SimpleLog simple = new SimpleLog(cw);
            DetailedLog detailed = new DetailedLog(cw);
            string text = "text";


            simple.LogError(text);
            simple.LogInfo("Simple info");
            simple.LogWarring("Simple warr");

            detailed.LogError("detailed err");
            detailed.LogInfo("detailed info");
            detailed.LogWarring("detailed warr");
            FileHelper fh = new FileHelper("File writer");

            SimpleLog simpleLog = new SimpleLog(fh);
            DetailedLog detailedLog = new DetailedLog(fh);


            simpleLog.LogError("Simple err");
            simpleLog.LogInfo("Simple info");
            simpleLog.LogWarring("Simple warr");

            detailedLog.LogError("detailed err");
            detailedLog.LogInfo("detailed info");
            detailedLog.LogWarring("detailed warr");


        }
    }
}
