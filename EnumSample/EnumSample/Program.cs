using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample
{
    class Program
    {
        enum Days { pzt, sali };
         
        static void Main(string[] args)
        {
            Days day1 = pzt;

            Console.WriteLine(day1);
        }
    }
}
