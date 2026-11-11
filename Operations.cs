using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleOnly
{
    public class Operations
    {
        public static void RunOperation(string character, string task)
        {
            Console.WriteLine($"{character} started {task}");

            Thread.Sleep(5000);

            Console.WriteLine($"{character} finished {task}");
        }
    }
}
