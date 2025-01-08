using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Greedy_Monocarp
{
    class Program
    {
        static void ProcessTestCase()
        {
            int totalElements, threshold;
            var inputs = Console.ReadLine().Split();
            totalElements = int.Parse(inputs[0]);
            threshold = int.Parse(inputs[1]);
 
            // Read the elements into an array
            var elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
 
            // Sort the array in descending order
            Array.Sort(elements, (a, b) => b.CompareTo(a));
 
            int accumulatedSum = 0;
            for (int i = 0; i < totalElements; i++)
            {
                accumulatedSum += elements[i];
                if (accumulatedSum > threshold)
                {
                    accumulatedSum -= elements[i];
                    Console.WriteLine(threshold - accumulatedSum);
                    return;
                }
            }
 
            // If no sum exceeds the threshold, print the remaining sum
            Console.WriteLine(threshold - accumulatedSum);
        }
 
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                ProcessTestCase();
            }
        }
    }
}
