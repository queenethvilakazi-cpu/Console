using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnly
{
    public abstract class Character
    {
        public int CharacterID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int StrengthLevel { get; set; }

        public Character(int id, string name, int age, int strength)
        {
            CharacterID = id;
            Name = name;
            Age = age;
            StrengthLevel = strength;
        }

        public abstract void PerformAction();
    }
}
