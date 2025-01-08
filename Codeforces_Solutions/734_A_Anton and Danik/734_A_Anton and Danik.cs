using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int countA = 0, countD = 0;
 
            for (int i = 0;i < n; i++)
            {
                if(s[i]=='A')
                {
                    countA++;
                }
                else
                {
                    countD++;
                }
            }
            if(countA > countD)
            {
                Console.WriteLine("Anton");
            }
            else if(countA < countD)
            {
                Console.WriteLine("Danik");
            }
            else
            {
                Console.WriteLine("Friendship");
            }
 
 
        }
    }
}
