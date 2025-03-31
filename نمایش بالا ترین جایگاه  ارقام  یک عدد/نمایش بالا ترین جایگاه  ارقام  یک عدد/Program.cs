using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace نمایش_بالا_ترین_جایگاه__ارقام__یک_عدد
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            Console.WriteLine("ple enter number : ");
            num = int.Parse(Console.ReadLine());
            if (num < 10)
                Console.WriteLine("result : " + num);
            else if (num < 100)
                Console.WriteLine("result : " + (num / 10));
            else if (num < 1000)
                Console.WriteLine("result : " + (num / 100));
            else if (num < 10000)
                Console.WriteLine("result : " + (num / 1000));
            else if (num < 100000)
                Console.WriteLine("result : " + (num / 10000));
            else
                Console.WriteLine("error");
            Console.ReadKey();
        }
    }
}
