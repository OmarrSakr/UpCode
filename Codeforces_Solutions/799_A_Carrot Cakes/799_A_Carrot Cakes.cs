using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf23
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[]record=Console.ReadLine().Split(' ');
 
            int n=int.Parse(record[0]);  // Number of (cakes) for complete Task
            int t=int.Parse(record[1]);  // Number of (minutes) for number of (K)
            int k=int.Parse(record[2]);   // (K) Number of Cakes Boke in the Limit time is (t) 
            int d=int.Parse(record[3]);   // Numbers of (minutes) we need for do (the second Oven)
 
          int r=(d+t)/ t; // ( r ) represent rate time of two ovens
 
            if(r * k < n)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
 
        }
    }
}
