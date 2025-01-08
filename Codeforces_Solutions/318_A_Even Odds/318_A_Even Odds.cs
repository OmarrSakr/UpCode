using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Even_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long k = long.Parse(input[1]); // ا1) لفهرس المطلوب-based index)
 
 
            // حساب عدد الأعداد الفردية
            long oddCount = (n + 1) / 2;
 
            if(k <= oddCount)
            {
                // الرقم فردي
                Console.WriteLine(1 + (k-1) *2 );
            }
            else
            {
                // الرقم زوجي
                Console.WriteLine(2 + (k-oddCount-1) *2 );
            }
 
        }
    }
}
