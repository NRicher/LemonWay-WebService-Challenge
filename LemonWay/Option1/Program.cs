using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option1
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.LemonWay lemonWay = new localhost.LemonWay();
            Console.WriteLine(lemonWay.Fibonacci(10));
            Console.ReadKey();
        }
    }
}
