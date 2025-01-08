using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine().ToUpper();
            string t=Console.ReadLine().ToUpper();
 
            int position = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == s[position])
                {
                    position++;
                }
                if (position==s.Length)
                {
                    break;
                }
 
            }
            Console.WriteLine(position + 1);   // ( الموضع النهائي (مع زيادة 1 لأن الترقيم يبدأ من 1
        }
    }
}
