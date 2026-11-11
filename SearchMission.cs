using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnly
{
    public class SearchMission : Mission
    {
        public override void ExecuteMission()
        {
            Console.WriteLine("Searching for Gollum...");
        }
    }
}
