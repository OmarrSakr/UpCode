using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int[] column = new int[n];
 
            string[] firstline = Console.ReadLine().Split(' ');
            for(int i = 0;i<n;i++)
            {
                column[i] = int.Parse(firstline[i]);
               
            }
            Array.Sort(column);
            Console.WriteLine(string.Join(" ",column));
 
 
        }
    }
}
