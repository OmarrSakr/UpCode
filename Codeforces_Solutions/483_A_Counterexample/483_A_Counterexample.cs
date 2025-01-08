using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Counterexample
{
    class Program
    {
        static long GCD(long x , long y)
        {
            while (y != 0)
            {
                long temp = y;
                y = x % y;
                x = temp;
            }
            return x;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long l = long.Parse(input[0]);
            long r = long.Parse(input[1]);
 
            for(long a = l; a <= r - 2; a++)
            {
                for (long b = a+1; b <= r - 1; b++)
                {
                    for (long c = b+1; c <= r ; c++)
                    {
                        if(GCD(a,b) ==1 && GCD(b,c) == 1 && GCD(a,c) != 1)
                        {
                            Console.WriteLine($"{a} {b} {c}");
                            return;
                        }
                    }
                }
            }
            // If no solution found
            Console.WriteLine("-1");
 
        }
    }
}
