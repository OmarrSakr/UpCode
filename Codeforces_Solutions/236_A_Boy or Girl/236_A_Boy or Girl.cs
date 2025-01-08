using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
 
            // استخدام HashSet لتخزين الأحرف الفريدة
            HashSet<char> distinctChars = new HashSet<char>();
 
            //  foreach لتحديد عدد الأحرف الفريدة في الاسم
            // for ل محتاج تعدل في حاجة استخدم 
            foreach (char c in name)
            {
                distinctChars.Add(c);
            }
 
            
            int distinctCount = distinctChars.Count;
 
            
            if (distinctCount % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }
 
        }
    }
}
