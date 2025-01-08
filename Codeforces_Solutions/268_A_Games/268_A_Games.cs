using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var teams = new (int home, int guest)[n];
            
 
            for(int i = 0; i < n; i++)
            {
                string[] record = Console.ReadLine().Split(' ');
                int homecolor= int.Parse(record[0]);
                int guestcolor= int.Parse(record[1]);
 
                    teams[i] =(homecolor,guestcolor);
                
            }
            int count = 0;
 
            for(int i = 0;i < n; i++)
            {
                for(int j = 0;j < n; j++)
                {
                    // إذا كان الفريقين مختلفين ولون زي المنزل للفريق المضيف يطابق لون زي الضيف للفريق الضيف
                    if (i!=j && teams[i].home==teams[j].guest)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
 
        }
    
    }
}
