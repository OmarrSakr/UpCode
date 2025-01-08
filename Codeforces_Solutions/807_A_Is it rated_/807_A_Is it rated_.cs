using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Is_it_rated
{
    class Program
    {
        static void Main(string[] args)
        {
            int participants = int.Parse(Console.ReadLine()); // n
            int[] ai = new int[participants];
            int[] bi = new int[participants];
 
            bool isRated = false;
            bool isUnrated = false;
 
            for(int i = 0; i < participants; i++)
            {
            string[] input = Console.ReadLine().Split();
                 ai[i] = int.Parse(input[0]);
                 bi[i] = int.Parse(input[1]);
 
                if(ai[i] != bi[i])
                {
                    isRated = true;
                }
            }
            if (isRated)
            {
                Console.WriteLine("rated");
                return;
            }
            for (int i = 1; i < participants; i++)
            {
                if (ai[i] > ai[i - 1])
                {
                    isUnrated = true;
                    break;
                }
            }
 
                if (isUnrated)
            {
                Console.WriteLine("unrated");
            }
            else
            {
                Console.WriteLine("maybe");
            }
        }
    }
}
