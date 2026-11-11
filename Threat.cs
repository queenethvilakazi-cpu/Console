using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnly
{
    public class Threat
    {
        public int ThreatID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        private int dangerLevel;

        public int DangerLevel
        {
            get
            {
                return dangerLevel;
            }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new InvalidThreatException(
                        "Danger level must be between 1 and 10.");
                }

                dangerLevel = value;
            }
        }

        public Threat(int id, string name, string location, int dangerLevel)
        {
            ThreatID = id;
            Name = name;
            Location = location;
            DangerLevel = dangerLevel;
        }
    }
}
