using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18._05Agent
{
    static class IntelTools
    {
        public static string EncryptMessage(string msg)
        {
            
            return new string(msg.Reverse().ToArray());

        }
        public static void LogTransmission(Agent agentName, string message)
        {
            Console.WriteLine($"{agentName.GetCodeName()} sent encrypted message: {message}");
        }
    }
}
