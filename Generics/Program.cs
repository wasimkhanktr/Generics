using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maximum<int> maximum = new Maximum<int>();
            int max = maximum.FindMax(1, 2, 3);
            Maximum<string> maximum1 = new Maximum<string>();
            string max1 = maximum1.FindMax("Apple", "Banana", "Peach");
            Console.WriteLine(max);
            Console.WriteLine(max1);
        }
    }
}