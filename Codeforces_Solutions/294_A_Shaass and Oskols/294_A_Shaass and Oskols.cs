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
           int n=int.Parse(Console.ReadLine()); // numbers of wires
            int[]numbirds = new int[n];         // numbers of birds on each wire
            string[]records = Console.ReadLine().Split(' ');
            for(int i=0; i<n; i++)
            {
                numbirds[i] = int.Parse(records[i]);
 
            }
 
            int m = int.Parse(Console.ReadLine()); // numbers of shots
                                                  
            for (int i = 0; i < m; i++)
            {
                string[] shotdetails = Console.ReadLine().Split(' ');
 
                int x = int.Parse(shotdetails[0]) - 1;  /// تحويل إلى مؤشر (0-based index)
                int y = int.Parse(shotdetails[1]);
 
                if (x > 0)
                {
                    numbirds[x - 1] += y - 1; // الطيور التي تطير إلى السلك العلوي
                }
 
                // الطيور التي تطير إلى السلك السفلي
                if (x < n - 1)
                {
                    numbirds[x + 1] += numbirds[x] - y ; // الطيور التي تطير إلى السلك السفلي
                }
 
                // تحديث عدد الطيور على السلك المستهدف
                numbirds[x] = 0;
 
            }
 
            for(int i = 0;i < n; i++)
            {
                Console.WriteLine(numbirds[i]);
            }
 
        }
    }
}
