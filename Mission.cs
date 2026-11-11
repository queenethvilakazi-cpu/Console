using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnly
{
    public abstract class Mission : IMission
    {
        public int MissionID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int DangerLevel { get; set; }
        public bool CompletionStatus { get; set; }

        public abstract void ExecuteMission();
    }
}
