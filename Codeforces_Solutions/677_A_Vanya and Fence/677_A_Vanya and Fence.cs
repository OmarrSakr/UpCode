using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace for_demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string[] firstLine = Console.ReadLine().Split(' ');
            int n = int.Parse(firstLine[0]);
            int h = int.Parse(firstLine[1]);
 
            string[] secondLine = Console.ReadLine().Split(' ');
            int[] heights = new int[n];
                for (int i = 0; i < n; i++)
                {
                   
                    heights[i] = int.Parse(secondLine[i]); 
                }
            int width_road = 0;
            for (int i = 0; i < n; i++)
                {
                    if (heights[i] > h)
                    {
                        width_road += 2;
 
                    }
                    else
                    {
                        width_road += 1;
                    }
 
                }
                Console.WriteLine(width_road);
 
            }
        }
    }
