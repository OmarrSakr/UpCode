using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Keyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "qwertyuiopasdfghjkl;zxcvbnm,./";
            string LR=Console.ReadLine();
            if(LR.Length!=1 || (LR!="L" && LR!="R"))
            {
                return;
            }
            LR = LR.ToUpper();
 
            string input = Console.ReadLine();
   
 
            StringBuilder output = new StringBuilder();
            foreach (char c in input)
            {
                int index = value.IndexOf(c);
                if(index == -1)
                {
                    return;
                }
                if (LR == "R")
                {
                    if(index - 1 >= 0)
                    {
 
                      output.Append(value[index - 1]);
                    }
                }
                else
                {
                    if (index + 1 < value.Length)
                    {
                        output.Append(value[index + 1]);
                    }
 
                }
            }
            Console.WriteLine(output.ToString());
 
        }
    }
}
