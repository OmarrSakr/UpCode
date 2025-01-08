using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Launch_of_Collider
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input the number of particles
            int n = int.Parse(Console.ReadLine());
 
            // Input the directions
            string directions = Console.ReadLine().ToUpper();
 
            // Input the positions
            string[] positionsInput = Console.ReadLine().Split();
            int[] positions = Array.ConvertAll(positionsInput, int.Parse);
 
           
            int minTime = int.MaxValue;
            bool collisionPossible = false;
 
           
            for (int i = 0; i < n - 1; i++)
            {
                
                if (directions[i] == 'R' && directions[i + 1] == 'L')
                {
                   
                    int time = (positions[i + 1] - positions[i]) / 2;
 
                   
                    minTime = Math.Min(minTime, time);
                    collisionPossible = true;
                }
            }
 
 
            Console.WriteLine(collisionPossible ? minTime : -1);
        }
    }
    
}
