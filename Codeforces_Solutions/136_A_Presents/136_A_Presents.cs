using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] P= Console.ReadLine().Split();
 
            // تخزين الأرقام في مصفوفة أو طباعتها
            int[] result = new int[n];
 
            for (int i = 0; i < n; i++)
            {
                int friendNumbers = int.Parse(P[i]);
                result[friendNumbers-1] = i+1;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
