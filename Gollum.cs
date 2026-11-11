using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnly
{
    public class Gollum : Character
    {
        public string CaveLocation { get; set; }

        public Gollum(int id, string name, int age, int strength, string caveLocation)
            : base(id, name, age, strength)
        {
            CaveLocation = caveLocation;
        }

        public override void PerformAction()
        {
            Console.WriteLine($"{Name} is hiding in {CaveLocation}");
        }
    }
}
