
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Mahmoud_and_Longest
{
    class Program
    {
        static void Main(string[] args)
        {
            string seqA = Console.ReadLine();
            string seqB = Console.ReadLine();
 
            if (seqA == seqB)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(Math.Max(seqA.Length, seqB.Length));
            } 
 
        }
    }
}
