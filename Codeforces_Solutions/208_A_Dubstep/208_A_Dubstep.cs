using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Dubstep
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToUpper();
 
            if (input.Length > 200) return;
 
            string result = input.Replace("WUB", " ");
 
            // Trim any extra spaces and collapse multiple spaces into a single one
            result = System.Text.RegularExpressions.Regex.Replace(result, @"\s+", " ").Trim();
 
            Console.WriteLine(result);
 
 
        }
    }
}
