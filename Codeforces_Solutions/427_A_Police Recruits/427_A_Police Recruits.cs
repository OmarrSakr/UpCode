using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            string[] record=Console.ReadLine().Split(' ');
            int[]occur=new int[n];
            for(int i=0; i<n; i++)
            {
                occur[i]=int.Parse(record[i]);  
            }
            int untreated = 0;
            int availableofficers = 0;
            for(int i=0; i<n; i++)
            {
               if( occur[i] == -1)     // the first step
                {
                   if(availableofficers >0)
                    {
                        availableofficers--;
                    }
                    else
                    {
                        untreated++;
                    }
                }
                else                          //the second step
                {
                    availableofficers=availableofficers+occur[i];
                }
            }
            Console.WriteLine(untreated);
 
        }
    }
}
