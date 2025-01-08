using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
 
namespace cf3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] onlyline=Console.ReadLine().Split(' ');
            int x=int.Parse(onlyline[0]);
            int y=int.Parse(onlyline[1]);
 
            int countyears = 0;
 
            while(x <= y)
            {
                x *= 3;
                y*=2;
                countyears++;
            }
            Console.WriteLine(countyears);
 
        }
    }
}
