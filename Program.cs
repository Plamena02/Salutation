using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = (Console.ReadLine());
            if (b == "f")
            { if (a < 16)
                { Console.WriteLine("Miss"); }
                else Console.WriteLine("Ms.");
            }
            else if(b=="m")
            { if (a < 16)
                { Console.WriteLine("Master"); }
                else Console.WriteLine("Mr.");
            }

        }
    }
}
