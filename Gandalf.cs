using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnly
{
    public class Gandalf : Character
    {
        public string StaffType { get; set; }

        public Gandalf(int id, string name, int age, int strength, string staffType)
            : base(id, name, age, strength)
        {
            StaffType = staffType;
        }

        public override void PerformAction()
        {
            Console.WriteLine($"{Name} casts a spell using {StaffType}");
        }
    }
}
