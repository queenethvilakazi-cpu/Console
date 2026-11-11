using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnly
{
    public class Aragorn : Character
    {
        public string Weapon { get; set; }

        public Aragorn(int id, string name, int age, int strength, string weapon)
            : base(id, name, age, strength)
        {
            Weapon = weapon;
        }

        public override void PerformAction()
        {
            Console.WriteLine($"{Name} attacks using {Weapon}");
        }
    }
}
