using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
 
namespace cf20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] records = Console.ReadLine().Split(' ');
           
           int y=int.Parse(records[0]);
           int w=int.Parse(records[1]);
 
            int maxroll=Math.Max(y,w);
 
                                                        //إذا كانت النتيجة الأعلى هي 4، فإن Dot يمكنها الفوز أو التعادل إذا حصلت على 4، 5، أو 6.Dot
                                                        //  عدد النتائج الممكنة هو: 6 - 4 + 1 = 3.
 
            int resultoutGame =(6-maxroll+1);   // عدد الاحتمالات لفوز او تعادل Dot 
 
                                                        // دا مجرد احتمالات ل resultoutGames {لو طلع ناتج بتاعها {0,1,2,3,4,5,6
                                                        // لو طلع ناتج اي حاجة من الحاجات اللي فوق دا بقسم ع 6
 
            string[] fractions = { "0/1", "1/6","1/3","1/2","2/3","5/6","1/1" };
 
 
            Console.WriteLine(fractions[resultoutGame]);
 
 
        }
    }
}
