using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A__King_Keykhosrow_s_Mystery
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());  // the number of test cases.
 
            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
 
 
                int gcd = GCD(a, b);
                int result = (a / gcd) * b; 
                Console.WriteLine(result);
            }
        }
        //العامل المشترك
        static int GCD(int x ,int y)
        {
            while(y != 0)
            {
            int temp = y;
                y = x % y;
                x = temp;
            }
            return x;
        }
    }
}
