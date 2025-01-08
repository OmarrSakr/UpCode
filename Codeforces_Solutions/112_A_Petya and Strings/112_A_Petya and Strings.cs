using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firststring=Console.ReadLine();
            firststring= firststring.ToLower();
            string secondstring=Console.ReadLine();
            secondstring = secondstring.ToLower();
 
            int verify = string.Compare(firststring,secondstring);
 
            if(verify > 0)
            {
                Console.WriteLine("1");
            }
            else if(verify < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("0");
            }
 
 
        }
    }
}
