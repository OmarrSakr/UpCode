using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Arpa_s_hard_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            if(n == 0)
            {
                Console.WriteLine("1");
                return;
            }
 
            //اشتغلنا هنا علي اخر رقم اللي هو 8 وبدا نحط علية اس من 1 الي 9 هتلاقي ان اول اربعة اس اللي هما 1 و2 و3 و4 بيطلعوا اخر رقم مختلف شوية
            //لكن لو حطيت اس 5 مثلا وعدنا الدورة هتلاقي نفس اخر رقم ل الاس واحد هو هو نفس اخر رقم لاس 5
            int result = (int)(n % 4);
            if (result == 1)
            {
                Console.WriteLine("8");
            }else if(result == 2)
            {
                Console.WriteLine("4");
            }else if(result == 3)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("6");
            }
        }
    }
}
