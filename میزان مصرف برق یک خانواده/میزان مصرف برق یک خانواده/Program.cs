using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace میزان_مصرف_برق_یک_خانواده
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, h;
            Console.Write("Please enter the amount consumed : ");
            k = int.Parse(Console.ReadLine());
            if (k <= 5)
            {
                h = 0;
            }
            else if (k <= 20)
            {
                h = (k - 5) * 1000;
            }
            else if (k > 20)
            {
                h = 15000 + ((k - 20) * 5000);
            }
            Console.WriteLine(h);
        }
    }
}
