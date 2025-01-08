using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace B.Kevin_and_Permutation
{
    class Program
    {
        static void Solve()
        {
            int n, k;
            string[] input = Console.ReadLine().Split();
            n = int.Parse(input[0]);
            k = int.Parse(input[1]);
 
            List<int> ans = new List<int>(new int[n]); // قائمة لتخزين الإجابة
            int j = 1;
 
            // تعيين القيم في كل موضع في الكثافة k
            for (int i = k - 1; i < n; i += k, j++)
            {
                ans[i] = j;
            }
 
            // تعبئة المواضع المتبقية
            for (int i = 0; i < n; i++)
            {
                if ((i + 1) % k != 0)
                {
                    ans[i] = j;
                    j++;
                }
            }
 
            // طباعة النتيجة
            Console.WriteLine(string.Join(" ", ans));
        }
 
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine()); // قراءة عدد حالات الاختبار
            while (tc-- > 0)
            {
                Solve(); // حل كل حالة
                Console.WriteLine();
            }
        }
    }
}
