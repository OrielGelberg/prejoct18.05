using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18._05Agent
{
    internal class Mission
    {
        private string MissionName;
        private string TargetLocation;
        Agent AssignedAgent;

        public Mission(string missionName, string targetLocation, Agent assignedAgent)
        {
            MissionName = missionName;
            TargetLocation = targetLocation;
            AssignedAgent = assignedAgent;
        }   

        public string GetMissionName()
        {
            return MissionName;
        }

        public string GetTargetLocation()
        {
            return TargetLocation;
        }

        public Agent GetAssignedAgent()
        {
            return AssignedAgent;
        }

        public void Brief()
        {
            Console.WriteLine($"Mission: {MissionName}, Target: {TargetLocation},Agent: {AssignedAgent.GetCodeName()}");
        }



    }
}
