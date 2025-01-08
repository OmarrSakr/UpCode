using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
 
namespace cf21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w=int.Parse(Console.ReadLine());
 
            // د12)ا شرط بيقولك حتي العدد اللي انت مدخلة كام زوجي لازم يكون تقسيمة تتكون من عددين زوجيين حتي لو مش متساووين يعني => divided into (4) and (8)  
 
            // Output=> Print YES, if the boys can divide the watermelon into two parts, each of them weighing even number of kilos
            if (w%2==0 && w>2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
