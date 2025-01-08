using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Chewbaсca_and_Number
{
    class Program
    {
        static void Main(string[] args)
        {
 
                string x = Console.ReadLine();
                char[] arr = x.ToCharArray(); // تحويل السلسلة إلى مصفوفة من الأحرف
 
                for (int i = 0; i < arr.Length; i++)
                {
                    if(arr[i]=='9'&& i==0)
                    {
                    arr[i] = arr[i];
                    }
                    // إذا كانت القيمة أكبر من أو تساوي 5، نقوم بتعديل الرقم
                    else if (arr[i] >= '5')
                    {
                        arr[i] = (char)('9' - arr[i] + '0'); // لو معلمتش كدا هيطلع ليك Askii code 0 =>255 كل رقم قدامة حرف في Keyboard
                    }
                    else
                    {
                        arr[i] = arr[i];
                    }
                }
 
                // إعادة السلسلة المعدلة إلى الشكل النصي
                Console.WriteLine(new string(arr));
            
        }
    }   
}
