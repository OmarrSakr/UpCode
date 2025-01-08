using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Panoramix_s_Prediction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
 
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
 
 
            if (isPrime(m) && GetNextPrime(n) == m)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
           static bool isPrime(int num)
           {
               if (num < 2) return false;
                for(int i = 2; i < num; i++)
                {
                    if(num% i == 0)
                    {
                        return false;
                    }
                }
                return true;
           }
            static int GetNextPrime(int start)
            {
                int next = start + 1;
                while (!isPrime(next))
                {
                    next++;
                }
            return next;
            }
 
 
    }
}
