using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Mountain_Scenery
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]); // n: عدد قمم الجبال.
            int k = int.Parse(input[1]); //k: عدد القمم المعدلة التي تم رفعها.
 
 
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
 
            for (int i = 1; i < r.Length - 1; i += 2)
            {
                if(k > 0 && r[i] > r[i - 1] && r[i] > r[i + 1])
                {
                    r[i]--;// تقليل الارتفاع بمقدار 1
 
                    if (r[i - 1] < r[i] && r[i] > r[i + 1])
                    {
                        k--; // Decrease the number of modifications left// تقليل عدد القمم المعدلة
                    }
                    else
                    {
                        r[i]++; // Undo if it doesn't satisfy the condition
                    } 
                }
                if (k == 0)
                    break; // انتهت التعديلات المطلوبة
            }
 
            // إخراج النتيجة
            Console.WriteLine(string.Join(" ", r));
        }
    }
}
