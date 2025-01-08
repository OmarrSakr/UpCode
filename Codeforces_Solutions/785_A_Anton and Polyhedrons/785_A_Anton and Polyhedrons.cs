using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Anton_and_Polyhedrons
{
    class Program
    {
        static void Main(string[] args)
        {
          int n = int.Parse(Console.ReadLine());
            long result = 0;
 
            // Mapping polyhedron names to their face counts
            Dictionary<string, int> faceCounts = new Dictionary<string, int>
            {
                { "Tetrahedron", 4 },
                { "Cube", 6 },
                { "Octahedron", 8 },
                { "Dodecahedron", 12 },
                { "Icosahedron", 20 }
            };
 
            for (int i = 0; i < n; i++)
            {
                string polyhedron = Console.ReadLine();
                result += faceCounts[polyhedron];
            }
 
            Console.WriteLine(result);
        }
    }
}
