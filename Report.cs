using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18._05Agent
{
    internal class Report
    {
        private int UrgencyLevel;
        Agent SubmittedBy;
        private string summary;

        public Report(int urgencyLevel, Agent submittedBy, string summary)
        {
            UrgencyLevel = urgencyLevel;
            SubmittedBy = submittedBy;
            this.summary = summary;
        }
        public int GetUrgencyLevel()
        {
            return UrgencyLevel;
        }

    }
}
