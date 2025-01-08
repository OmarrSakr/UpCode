using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();   // // قراءة السلسلة المدخلة والتي تتضمن الأقواس User هو اللي هيدخلها كلها 
            input=input.Substring(1,input.Length-2);
            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("0");
                return;
            }
 
            string[] record = input.Split(',');
            HashSet<char> uniqueletters=new HashSet<char>();
            foreach (char c in input)
            {
                if (c != ' ' && c != ',')
                {
                  uniqueletters.Add(c);
                }
            }
          
                Console.WriteLine(uniqueletters.Count);
          
        }
    }
}
