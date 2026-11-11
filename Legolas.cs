using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnly
{
    public class Legolas : Character
    {
        public string BowType { get; set; }

        public Legolas(int id, string name, int age, int strength, string bowType)
            : base(id, name, age, strength)
        {
            BowType = bowType;
        }

        public override void PerformAction()
        {
            Console.WriteLine($"{Name} fires arrows using {BowType}");
        }
    }
}
