using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
 
namespace cf11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 1 to 1000 on the card
            int [] cards = new int[n];
            string[]separate= Console.ReadLine().Split(' ');
            for(int i = 0; i<n; i++)
            {
                cards[i] = int.Parse(separate[i]);
            }
            int sumSereja = 0;
            int sumDima = 0;
            int right = n-1;
            int left = 0;
 
            bool serejaTurn = true; // يستخدم لتبديل الأدوار بين سيريجا وديما
            while (right >= left)    
            {
                if(cards[right] >= cards[left])
                {
                    if(serejaTurn)
                    {
 
                        sumSereja += cards[right];
                    }
                    else
                    {
                        sumDima += cards[right];
 
                    }
 
                    right--; 
                }  
                else
                {
                        if(serejaTurn)
                        {
                            sumSereja += cards[left];
 
                        }
                        else
                        {
                            sumDima+= cards[left];
                        }
                    
 
                    left++;
                }
                serejaTurn = !serejaTurn; // تبديل الأدوار
            }
            Console.WriteLine($"{sumSereja} {sumDima}");
 
 
        }
    }
}
