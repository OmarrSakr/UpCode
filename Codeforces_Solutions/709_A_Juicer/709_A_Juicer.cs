using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]firstrecord=Console.ReadLine().Split(' ');
          
                int n = int.Parse(firstrecord[0]);
                int maxsize = int.Parse(firstrecord[1]);
                int wastelimit=int.Parse(firstrecord[2]);
            
            int[] orangesize=new int[n];
            string[] secondrecord = Console.ReadLine().Split(' ');
            int wastesection = 0;
            int emptycount = 0;
            for (int i = 0;i <n ;i++)
            {
                orangesize[i]=int.Parse(secondrecord[i]);
 
            }
 
            for(int i = 0; i <n ;i++)
            {
                if(orangesize[i] <= maxsize)
                {
                    wastesection += orangesize[i];
                }
 
                if (wastesection > wastelimit)
                {
                    emptycount++;           
                    wastesection = 0;                    //إعادة تعيين wasteSection إلى صفر فقط عند تجاوز الحد المسموح به
 
                }
 
            }
            Console.WriteLine(emptycount);
 
 
 
        }
    }
}
