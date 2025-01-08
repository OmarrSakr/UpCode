using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
 
namespace cf9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int countUpper = 0; int countLower = 0;
            foreach (char c in s)
            {
                if (Char.IsUpper(c))
                {
                    countUpper++;
                }
                else
                {
                    countLower++;
                }
            }
 
            if (countUpper > countLower)
            {
                Console.WriteLine(s.ToUpper());
            }
            else
            {
                Console.WriteLine(s.ToLower());
            }
 
        }
    }
}
