using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            byte n = 4;
            for (byte i = 1; i <= n; ++i)
            {
                for (byte j = 1; j <= i; ++j)
                {
                    Console.Write("{0,9}", i);
                }
                Console.WriteLine();
                for (byte j = 1; j <= i; ++j)
                {
                    Console.Write("{0,9}", i + 5);
                }
                Console.WriteLine();
                Console.WriteLine();
                for (byte f = 1; f <= i; ++f)
                {
                    Console.Write("{0,9}", i + 5);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
