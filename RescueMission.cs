using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnly
{
    public class RescueMission : Mission
    {
        public override void ExecuteMission()
        {
            Console.WriteLine("Rescuing captured character...");
        }
    }
}
