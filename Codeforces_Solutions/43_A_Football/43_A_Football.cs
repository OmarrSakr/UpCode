using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A.Football
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
 
            Dictionary<string, int> goals = new Dictionary<string, int>();
            for(int i = 1; i <= n; i++)
            {
                string teamName = Console.ReadLine();
 
                if (goals.ContainsKey(teamName))
                {
                    goals[teamName]++;
                }
                else
                {
                    goals[teamName] = 1;
                }
            }
 
            string Winner ="";
            int Maxgoals = 0;
            foreach(var team in goals)
            {
                if(team.Value > Maxgoals)
                {
                    Winner = team.Key;
                    Maxgoals = team.Value;
                }
            }
            Console.WriteLine(Winner);
            
 
        }
    }
}
