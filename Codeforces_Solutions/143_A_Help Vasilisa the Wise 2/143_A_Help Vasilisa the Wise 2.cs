using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Help_Vasilisa_the_Wise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] row = Console.ReadLine().Split();
            int r1 = int.Parse(row[0]);
            int r2 = int.Parse(row[1]);
            string[] col = Console.ReadLine().Split();
            int c1 = int.Parse(col[0]);
            int c2 = int.Parse(col[1]);
            string[] dig = Console.ReadLine().Split();
            int dig1 = int.Parse(dig[0]);
            int dig2 = int.Parse(dig[1]);
 
            int a, b, c, d;
            for(int i = 1; i < 10; i++)
            {
                a = i;
                for (int j = 1; j < 10; j++)
                {
                    b = j;
                    for (int k = 1; k < 10; k++)
                    {
                        c = k;
                        for (int l = 1; l < 10; l++)
                        {
                            d = l;
                            if(a !=b && a !=c && a!=d && b != c && b !=d && c != d)
                            {
                                if(a+b==r1 && c+d==r2 && a+c==c1 && b+d==c2 && a+d==dig1 && b + c == dig2)
                                {
                                    Console.WriteLine($"{a} {b}");
                                    Console.WriteLine($"{c} {d}");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(-1);
            return;
 
 
        }
    }
}
