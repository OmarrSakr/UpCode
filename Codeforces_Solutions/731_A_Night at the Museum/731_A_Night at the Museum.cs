using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace cf15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameexh = Console.ReadLine().Trim().ToLower();
            int totalroatation = 0;
            int CurrentPosition = 'a';
 
           foreach(char targetchar in nameexh)
            {
                //with ClockWise 
                int ClockWiseDistance = (targetchar - CurrentPosition + 26) % 26; //i put (+26) and (%26) if the result is nagative number 
                // Counter ClockWise
                int CounterClockWiseDistance = (CurrentPosition - targetchar + 26) % 26;
 
                totalroatation += Math.Min(ClockWiseDistance, CounterClockWiseDistance);
                CurrentPosition = targetchar;
 
            }
            Console.WriteLine(totalroatation);
        }
    }
}
