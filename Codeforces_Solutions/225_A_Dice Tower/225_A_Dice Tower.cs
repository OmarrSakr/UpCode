using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Dice_Tower
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //  the number of dice in the tower.
            int x = int.Parse(Console.ReadLine()); //  the number Bob sees at the top of the tower. 
            if(n < 1 || n > 100 || x < 1 || x > 6)return;
 
            int currentTop = x;
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
 
                int bottom = 7 - currentTop;
 
                if(currentTop == a || currentTop == b||bottom == a ||bottom == b)
                {
                    Console.WriteLine("NO");
                    return;
                }
                currentTop = bottom;
 
            }
            Console.WriteLine("YES");
 
            
        }
    }
}
