using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Snacktower
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] P = Console.ReadLine().Split();
 
            int[] snackSizes = new int[n];
            for (int i = 0; i < n; i++)
            {
                 snackSizes[i] = int.Parse(P[i]);
            }
 
            int expected = n;
            // مصفوفة لتخزين الوجبات التي تم وضعها في البرج
            HashSet<int> waitingSnacks = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                waitingSnacks.Add(snackSizes[i]);
 
                while (waitingSnacks.Contains(expected))
                {
                    Console.Write(expected + " ");
                    waitingSnacks.Remove(expected);
                    expected--;
                }
                    Console.WriteLine();
            }
 
        }
    }
}
