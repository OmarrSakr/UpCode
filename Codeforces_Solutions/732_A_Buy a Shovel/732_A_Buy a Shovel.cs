using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]record=Console.ReadLine().Split(' ');
            int k=int.Parse(record[0]);  
            int r=int.Parse(record[1]);   
            int totalcost;                      // numbers of shovels
            for ( int n=1;n<=10; n++)
            {
                 totalcost = k * n;
                if (totalcost % 10 == r || totalcost % 10 == 0)
                {
 
                    Console.WriteLine(n);
                    return;
                }
            }
         
 
        }
    }
}
