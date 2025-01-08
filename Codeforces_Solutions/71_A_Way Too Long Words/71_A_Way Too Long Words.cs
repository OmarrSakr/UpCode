using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
 
namespace cf21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            string[] words = new string[n];
            int count = 0;
            for(int i=0; i<n;i++)
            {
                words[i] = Console.ReadLine();
 
            }
            for(int i=0; i<n; i++)
            {
                if(words[i].Length > 10)
                {
 
                    count = words[i].Length - 2;  // حساب عدد الأحرف بين الأول والأخير
                    Console.WriteLine($"{words[i][0]}{count}{words[i][words[i].Length - 1]}");
                }
                else                             // إذا كانت الكلمة ليست أطول من 10 أحرف
                {
                    Console.WriteLine(words[i]);
                }
            }
         
 
        }
    }
}
