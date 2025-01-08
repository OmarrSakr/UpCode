using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Good_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]); // 10
            int k = int.Parse(input[1]); // 6
 
            if (n < 1 && n > 100 && k > 9 && k < 0) return;
 
            int count = 0;
            for(int i = 0; i < n; i++) // 0 to 9
            {
                string number = Console.ReadLine();
 
                bool isGood = true;
                for(int j = 0; j <= k; j++) // 0 to 6
                {
                    if (!number.Contains(j.ToString()))
                    {
                        isGood = false;
                        break;
                    }
                }
                if(isGood)
                {
                    count++;
                }
 
            }
            Console.WriteLine(count);
 
 
        }
    }
}
