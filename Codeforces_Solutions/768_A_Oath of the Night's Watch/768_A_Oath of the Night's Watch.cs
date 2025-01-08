using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Oath_of_the_Night_s_Watch
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number_Of_Stewards = int.Parse(Console.ReadLine());
 
            string[] P = Console.ReadLine().Split();
 
            int[] Values_Assigned_To_stewards = new int[Number_Of_Stewards];
            for (int i = 0; i < Number_Of_Stewards; i++)
            {
                Values_Assigned_To_stewards[i] = int.Parse(P[i]);
 
            }
            // إيجاد أقل قيمة وأعلى قيمة
            int minStrength = Values_Assigned_To_stewards.Min();
            int maxStrength = Values_Assigned_To_stewards.Max();
 
            int count = Values_Assigned_To_stewards.Count(x => x > minStrength && x < maxStrength);
            Console.WriteLine(count);
        }
    }
}
