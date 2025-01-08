using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] records = Console.ReadLine().Split(' ');
            int[] horseshoes = new int[4];
            for (int i = 0; i < 4; i++)
            {
                horseshoes[i] = int.Parse(records[i]);
            }
            int need = 0;
 
            // استخدام HashSet لتخزين الألوان الفريدة
            var uniquecolor =new HashSet<int>(horseshoes);
 
            need=4 - uniquecolor.Count;
            Console.WriteLine(need);
        }
    }
}
