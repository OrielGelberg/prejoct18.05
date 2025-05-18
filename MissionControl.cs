using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18._05Agent
{
    internal class MissionControl
    {
        public void AnalyzeReport(Report report)
        {
            // Analyze the report and determine the next steps
            if (report.GetUrgencyLevel() >= 4)
            {
                Console.WriteLine("Immediate response required");
                
            }
            else if (report.GetUrgencyLevel() <= 3)
            {
                Console.WriteLine("High priority. Monitor closely");
            }
            else
                Console.WriteLine("Routine analysis");
       
        }
    }
}
