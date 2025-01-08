using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n =int.Parse(Console.ReadLine());
            string[]magnet=new string[n];
            int group = 1;                       // 
            for (int i = 0; i < n; i++)
            {
                magnet[i]=Console.ReadLine();
 
            }
           
            for (int i = 1; i < n; i++)
            {                                    //0  1  2   3   4  5
                if (magnet[i] != magnet[i-1])   //10 10 10 (01) 10 10
                {
                    group++;
                }
            }
            Console.WriteLine(group);
 
 
        }
    }
}
