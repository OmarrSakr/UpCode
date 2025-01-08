using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Twins
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number_Of_Coins= int.Parse(Console.ReadLine());
            string[] P = Console.ReadLine().Split();
 
            int[] Seq_Of_n = new int[Number_Of_Coins];
 
            int sum = 0;
            for (int i = 0; i < Number_Of_Coins; i++)
            {
                Seq_Of_n[i] = int.Parse(P[i]);
                sum += Seq_Of_n[i];
            }
            Array.Sort(Seq_Of_n);
            Array.Reverse(Seq_Of_n);
            int sum1 = 0, counter = 0;
            for (int i = 0; i < Number_Of_Coins; i++)
            {
                if(sum1 > sum / 2)
                {
                    break;
                }
                else
                {
                    counter++;
                    sum1 += Seq_Of_n[i];
                }
            }
            Console.WriteLine(counter);
 
        }
    }
}
