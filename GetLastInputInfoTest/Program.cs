using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLastInputInfoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                uint t = GetLastInputInfoWrapper.GetLastInputTime();
                Console.WriteLine(t);
                System.Threading.Thread.Sleep(1000);
            }
            while (!Console.KeyAvailable);
            
        }
    }
}
