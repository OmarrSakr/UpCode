using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Lineland_Mail
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCities = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split();
 
            int[] X = new int[numbersOfCities];
            for (int i = 0; i < numbersOfCities; i++)
            {
                X[i] = int.Parse(inputs[i]);
            }
            for (int i = 0; i < numbersOfCities; i++)
            {
                int mini, maxi;
 
                //لحساب Mini
                if (i == 0)
                {
                    mini = X[i + 1] - X[i];
                }else if(i == numbersOfCities - 1)
                {
                    mini = X[i] - X[i-1];
                }
                else
                {
                    mini = Math.Min(X[i] - X[i - 1], X[i+1] - X[i]);
                }
                //لحساب Maxi
                maxi = Math.Max(X[i] - X[0], X[numbersOfCities - 1] - X[i]);
 
                Console.WriteLine($"{mini} {maxi}");
            }
        }
    }
}
