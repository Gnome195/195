using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace مضارب_5_بین_دو_عدد
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, i;
            Console.WriteLine("ple enter number 1 : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ple enter number 2 : ");
            b = int.Parse(Console.ReadLine());
            for (i = a + 1; i <= b - 1; i++)
                if (i % 5 == 0)
                    Console.WriteLine("result : " + i);
            Console.ReadKey();
        }
    }
}
