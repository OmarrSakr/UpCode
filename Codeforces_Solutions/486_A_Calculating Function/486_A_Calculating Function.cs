using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Calculating_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            // سؤال دا عبارة عن سلسلة من
            // (-1)^n *n 
            // يعني او n=2 
            //(-1)^1 *1 + (-1)^2 *2
            
            long result = (n % 2 == 0) ? (n/2) : -(n+1)/2;
            Console.WriteLine(result);
        }
    }
}
