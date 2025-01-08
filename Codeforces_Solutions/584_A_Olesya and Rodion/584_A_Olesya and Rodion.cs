using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Olesya_and_Rodion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]); // n=3 or(1 ≤ n ≤ 100) => any number consist of 3 digits
            int t = int.Parse(input[1]);
 
            // If t is 10 and n is 1, it's impossible to construct such a number
            if (n==1 && t == 10)
            {
                Console.WriteLine("-1");
                return;
            }
 
            if(t == 10)
            {
                Console.WriteLine("1" + new string('0', n - 1));
            }
            else
            {
                Console.WriteLine(t + new string('0', n - 1));
 
            }
 
        }
    }
}
