using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
 
namespace cf27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            string[] record = input.Split('+');
           
            Array.Sort(record);
            string result=string.Join("+", record);
            Console.WriteLine(result);
        }
    }
}
