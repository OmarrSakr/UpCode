using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
 
           string colors = Console.ReadLine().ToUpper();
            int problem = 0;
            if(colors.Length == n)
            {
                for (int i = 0; i < colors.Length-1; i++)
                {
                    if(colors[i] ==colors[i+1])
                    {
                        problem++;
                    }
 
                }
            }
            else
            {
                return;
            }
           
            Console.WriteLine(problem);
        }
    }
}
