using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Kevin_and_Combination_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); // عدد حالات الاختبار
            for (int i = 0; i < t; i++)
            {
                long x = long.Parse(Console.ReadLine()); // القيمة الأولية للـ x
 
                // الحل:
                // إذا كان العدد x يقبل القسمة على 33، فإن الجواب هو "YES"
                // وإلا إذا كان يحتوي على "33"، نزيلهما حتى نصل إلى الحل أو لا.
                if (x % 33 == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    string xStr = x.ToString();
                    bool possible = false;
 
                    while (xStr.Contains("33"))
                    {
                        xStr = xStr.Replace("33", ""); // إزالة أي "33" موجودة في الرقم
                        if (string.IsNullOrEmpty(xStr) || xStr == "0")
                        {
                            possible = true;
                            break;
                        }
                    }
 
                    if (possible)
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");
                }
            }
        }
    }
}
