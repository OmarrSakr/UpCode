using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace New_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int n = int.Parse(inputs[0]);
            int k = int.Parse(inputs[1]);
 
            for (int i = 0; i < n; i++)
            {
                char ch = (char)('a' + (i % k));
                Console.Write(ch);
            }
        }
    }
}
