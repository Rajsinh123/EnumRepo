using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum level
        {
            high,medium,low
        }
        static void Main(string[] args)
        {
            level m = level.high;
            Console.WriteLine("m");
            Console.ReadLine();

        }
    }
}
