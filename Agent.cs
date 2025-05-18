using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18._05Agent
{
    internal class Agent
    {
        private string CodeName;
        private int ClearanceLevel;

        public Agent(string codeName, int clearanceLevel)
        {
           SetCodeName(codeName);
            if (clearanceLevel < 0 || clearanceLevel > 5)
            {
                Console.WriteLine("Clearance level must be between 0 and 5. Setting to default level 0.");
                SetClearanceLevel(0);
            }
            else
            {
                SetClearanceLevel(clearanceLevel);
            }
        }
        public void SetCodeName(string codeName)
        {
            CodeName = codeName;
        }
        public void SetClearanceLevel(int clearanceLevel)
        {
            ClearanceLevel = clearanceLevel;


        }
        public string GetCodeName()
        {
            return CodeName;
        }
        public int GetClearanceLevel()
        {
            return ClearanceLevel;
        }
        public void Report()
        {
            Console.WriteLine($"Agent {CodeName} reporting. Clearance Level: {ClearanceLevel}.");
        }

    }
}
