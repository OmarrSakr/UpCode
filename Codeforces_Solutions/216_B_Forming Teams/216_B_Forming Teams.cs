using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace B.Forming_Teams
{
    class Program
    {
            static List<List<int>> graph;
            static bool[] visited;
 
    enum Status { PATH = 0, CYCLE = 1 }
 
        static Status DFS(int currentNode, int parentNode, ref int nodesCount)
        {
            if (visited[currentNode])
                return Status.CYCLE;
 
            visited[currentNode] = true;
 
            foreach (var childNode in graph[currentNode])
            {
                if (childNode != parentNode)
                {
                    nodesCount++;
 
                    if (DFS(childNode, currentNode, ref nodesCount) == Status.CYCLE)
                        return Status.CYCLE;
                }
            }
            return Status.PATH;
        }
 
        static void Main(string[] args)
        {
            // قراءة المدخلات
            var inputs = Console.ReadLine().Split();
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
 
            graph = new List<List<int>>(n);
            visited = new bool[n];
 
            for (int i = 0; i < n; i++)
                graph.Add(new List<int>());
 
            for (int i = 0; i < m; i++)
            {
                var edge = Console.ReadLine().Split();
                int x = int.Parse(edge[0]) - 1;
                int y = int.Parse(edge[1]) - 1;
 
                graph[x].Add(y);
                graph[y].Add(x);
            }
 
            int toRemove = 0;
 
            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    int nodesCount = 0;
                    Status result = DFS(i, -1, ref nodesCount);
 
                    if (result == Status.CYCLE && nodesCount % 2 == 1)
                        toRemove++;
                }
            }
 
            if ((n - toRemove) % 2 == 1)
                toRemove++;
 
            Console.WriteLine(toRemove);
        }
    }
}
