using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                int sum = 0;
                string[]inputs = Console.ReadLine().Split(' ');
 
                int petya = int.Parse(inputs[0]);
                int vasya = int.Parse(inputs[1]);
                int tonya = int.Parse(inputs[2]);
 
                 sum = petya + vasya + tonya;
 
                if(sum>=2)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
 
 
        }
  }
}
