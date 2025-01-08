using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Valera_and_X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // n => The Number of Array Line
            if (n < 3 && n >= 300 && n % 2 == 0) return;
 
            //Jagged Array
            //كل صف فيها ممكن يكون بطول مختلف(مش شرط كل صف يبقى بنفس الطول).
            char[][] grid = new char[n][];
            for(int i = 0; i < n; i++)
            {
                grid[i] = Console.ReadLine().ToCharArray();
            }
 
            // Get diagonal and non-diagonal letters
            char diagLetter = grid[0][0]; 
            char otherLetter = grid[0][1];
            if(diagLetter == otherLetter)
            {
                Console.WriteLine("NO");
                return;
            }
 
 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i == j || i + j == n - 1)
                    {
                        if (grid[i][j] != diagLetter)
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else
                    {
                        if(grid[i][j] != otherLetter)
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
