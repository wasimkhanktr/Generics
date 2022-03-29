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
            Maximum maximum = new Maximum();
            double max = maximum.FindMaxDouble(2.1, 1.3, 3.6);
            Console.WriteLine(max);
        }
    }
}