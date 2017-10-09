using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("asbdkjasbd");

            int a = 10;
            string b = "label";
            System.Console.WriteLine("Variables: {0} {1}", a, b);
            var c = "label2";

            System.Console.WriteLine("Type: {0}, Len: {1}, Val: {2}", c.GetType(), c.Length, c);
            
            
            System.Console.WriteLine("Press any key to exit. ");
            System.Console.ReadKey();
        }
    }
}
