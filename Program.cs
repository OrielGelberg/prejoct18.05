using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18._05Agent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agent agent1 = new Agent("8200", 4);
            Mission mission1 = new Mission("The atomic program", "Iran", agent1);
            Report report1 = new Report(4,agent1,"Mission successful");
            MissionControl missionControl = new MissionControl();
            agent1.Report();
            mission1.Brief();
            missionControl.AnalyzeReport(report1);
            string encryptedMessage = IntelTools.EncryptMessage("Top secret message");
            IntelTools.LogTransmission(agent1, encryptedMessage);
            Console.WriteLine("Press any key to exit...");

        }
    }
}
