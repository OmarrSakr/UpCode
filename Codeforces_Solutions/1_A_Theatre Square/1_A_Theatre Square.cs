using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Theatre_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
 
            long n = long.Parse(input[0]); // Length
            long m = long.Parse(input[1]); //Width
            long a = long.Parse(input[2]); // lenght and width of tiles البلاط .. لان طول والعرض للبلاط متساوي a*a
 
            long tilesINLength = (n + a - 1) / a;
            long tilesINWidth = (m + a - 1) / a;
 
            long TotalTiles = tilesINLength * tilesINWidth;
            Console.WriteLine(TotalTiles);
 
       
        }
    }
}
