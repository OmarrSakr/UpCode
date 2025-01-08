using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
 
namespace cf26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] record = Console.ReadLine().Split(' ');
 
            int n = int.Parse(record[0]);  // the number of quere
            long x = int.Parse(record[1]);  // the initially amount of ice Cream
 
            int left = 0;
            for (int i = 0; i < n; i++)
            {
                string[] operation = Console.ReadLine().Split(' ');
                char op = operation[0][0]; // operation is meaning = -(number) or +(number) => so - or + is [0] and number is [1]
                long number = int.Parse(operation[1]);
 
                if (op == '+')
                {
                    x += number;
                }
                else if (op == '-')
                {
 
                    if (x >= number)
                    {
                        x -= number;
                    }
                    else
                    {
                        left++;
                    }
 
                }
            }
            Console.WriteLine($"{x} {left}");
 
        }
    }
}
