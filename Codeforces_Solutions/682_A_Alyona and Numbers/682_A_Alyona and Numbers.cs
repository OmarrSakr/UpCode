using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Alyona_and_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long m = long.Parse(input[1]);
 
 
            // حساب عدد الأعداد التي تحقق كل باقي قسمة من 0 إلى 4
            long[] countN = new long[5];
            long[] countM = new long[5];
 
            for (int i = 0; i < 5; i++)
            {
                countN[i] = n / 5; // القيم التي تقبل القسمة بالكامل [ 1,1,1,1,1] 0
                                   // n = 6
                countM[i] = m / 5; // القيم التي تقبل القسمة بالكامل
                                   // m =12
            }
 
            // إضافة القيم التي تحقق باقي القسمة من الباقي الموجود (n % 5)
            for (int i = 1; i <= n % 5; i++) 
            {
                countN[i]++;  // [2,1,1,1,1]
            }
            for (int i = 1; i <= m % 5; i++)
            {
                countM[i]++; // [2,3,3,2,2]
            }
 
 
            long result = 0;
            for(int x = 0; x < 5; x++)
            {
                int y = (5 - x) % 5;
                result += countN[x] * countM[y];
            }
 
            Console.WriteLine(result);
        }
    }
}
