using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] record = Console.ReadLine().Split(' ');
 
            int[] firstline = new int[4];  // the first line => consist of ( 4 ) numbers of calories and their is four number represent calories
            for (int i = 0; i < 4; i++)
            {
                firstline[i] = int.Parse(record[i]);
            }
 
            string s = Console.ReadLine();         //the second line => consist of 1 2 3 4
            int calories = 0;
            for(int i = 0;i < s.Length; i++)
            {
                if(s[i] =='1')
                {
                    calories += firstline[0];
                }
                else if(s[i] =='2')
                {
                    calories += firstline[1];
                }
                else if (s[i] =='3')
                {
                    calories += firstline[2];
                }
                else
                {
                    calories += firstline[3];
                }
            }
            Console.WriteLine(calories);
 
        }
    }
}
