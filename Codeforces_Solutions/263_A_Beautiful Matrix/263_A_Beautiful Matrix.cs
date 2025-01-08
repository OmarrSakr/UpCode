using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
 
namespace cf5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =new int[5,5];
            int onerow = -1;
            int onecolumn = -1;
            for (int i=0; i<5; i++)
            {
                string[]record =Console.ReadLine().Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    matrix[i,j] = int.Parse(record[j]);
 
                    if (matrix[i, j] == 1)
                    {
                        onerow = i; onecolumn = j;
                    }
                }
               
            }
           
           int move =Math.Abs(onerow-2)+Math.Abs(onecolumn-2);
            Console.WriteLine(move);
        }
    }
}
