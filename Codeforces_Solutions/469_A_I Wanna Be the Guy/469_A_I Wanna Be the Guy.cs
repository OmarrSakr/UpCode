using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.I_Wanna_Be_the_Guy
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = int.Parse(Console.ReadLine());  // n
            string[] indicateX = Console.ReadLine().Split();
            string[] indicateY = Console.ReadLine().Split();
 
            List<int> Xlevels = indicateX.Skip(1).Select(int.Parse).ToList();
            List<int> Ylevels = indicateY.Skip(1).Select(int.Parse).ToList();
 
 
            var AllLevels = Xlevels.Concat(Ylevels).ToHashSet();
 
            if (AllLevels.Count == levels)
            {
                Console.WriteLine("I become the guy.");
            }
            else
            {
                Console.WriteLine("Oh, my keyboard!");
            }
        }
    }
}
