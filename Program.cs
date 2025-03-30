using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace حاصل_طبق_کاراکتر_در_یافتی
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            int c;
            Console.WriteLine("ple enter number 1 : ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("ple enter number 2 : ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the desired operation number : ");
            Console.WriteLine("1- Multiplication ");
            Console.WriteLine("2- Division ");
            Console.WriteLine("3- Plural ");
            Console.WriteLine("4- minus ");
            Console.Write("Number : ");
            c = int.Parse(Console.ReadLine());
            if (c == 1)
                Console.WriteLine("result = " + (a * b));
            else if(c==2)
                Console.WriteLine("result = " + (a / b));
            else if (c == 3)
                Console.WriteLine("result = " + (a + b));
            else if (c == 4)
                Console.WriteLine("result = " + (a - b));
            Console.ReadKey();
        } 
    }
}
