using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int a1 = 0;
            int a2 = 1;
            int n = 1;
            while (a == 0)
            {
                Console.WriteLine(0);
                if (a2 <= a)
                {
                    if (a1 <= a)
                        Console.WriteLine(n);
                    
                    n += 1;
                    Console.WriteLine(n);
                }    
                else
                    Console.WriteLine(-1);
            }
            Console.ReadKey();

        }
    }
}
