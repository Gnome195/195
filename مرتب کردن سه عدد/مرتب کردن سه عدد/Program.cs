using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace مرتب_کردن_سه_عدد
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("ple number 1 : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ple number 1 : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("ple number 1 : ");
            c = int.Parse(Console.ReadLine());
            if(a>b)
            {
                d = a;a = b;b = d;
            }
            if (a > c)
            {
                d = a;a = c;c = d;
            }
            if(b>c)
            {
                d = a;a = c;c = d;
            }
            Console.WriteLine(a + "-" + b + "-" + c + "");
            Console.ReadLine();


        }
    }
}
