using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]record=Console.ReadLine().Split(' ');
            int M =int.Parse(record[0]); //M N these are dimensions
            int N =int.Parse(record[1]);
 
            int maxDominoes = (M * N)/2 ;
 
            Console.WriteLine(maxDominoes);
 
        }
    }
}
