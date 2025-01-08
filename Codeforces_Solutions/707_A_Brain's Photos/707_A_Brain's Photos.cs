using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Brain_s_Photos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
 
 
            bool isColor = false;
 
            for(int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split();
 
                foreach(string pixel in row)
                {
                    if (pixel == "C" || pixel == "M" || pixel == "Y")
                    {
                        isColor = true;
                        break;
                    }
                    if(isColor)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(isColor? "#Color" : "#Black&White");
        }
    }
}
