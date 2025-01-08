using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Ksenia_and_Pan_Scales
{
    class Program
    {
        static void Main(string[] args)
        {
            // قراءة المدخلات
            string[] scales = Console.ReadLine().Split('|');
            string left = scales[0];
            string right = scales[1];
            string unusedWeights = Console.ReadLine();
 
            // حساب الطول الحالي لكل كفة
            int leftLength = left.Length;
            int rightLength = right.Length;
 
            // إجمالي الأوزان المتاحة
            int totalWeights = unusedWeights.Length;
 
            // التحقق من إمكانية تحقيق التوازن
            int diff = Math.Abs(leftLength - rightLength);
 
            // إذا لم يكن عدد الأوزان المتبقية مناسبًا لتحقيق التوازن
            if ((diff > totalWeights)|| ((totalWeights - diff) % 2 != 0))
            {
                Console.WriteLine("Impossible");
                return;
            }
 
            // توزيع الأوزان لتحقيق التوازن
            int toLeft = (totalWeights - diff) / 2;
            int toRight = toLeft;
 
            if (leftLength < rightLength)
            {
                toLeft += diff;
            }
            else
            {
                toRight += diff;
            }
 
            left += unusedWeights.Substring(0, toLeft); //A | BC  //DEF
 
            right += unusedWeights.Substring(toLeft);
 
            // طباعة النتيجة
            Console.WriteLine(left + "|" + right);
        }
    }
}
