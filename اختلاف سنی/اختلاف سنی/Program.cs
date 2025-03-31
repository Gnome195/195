using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace اختلاف_سنی
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y1, m1, d1, y2, m2, d2, k1, k2, a1, a2, e;
            Console.WriteLine("Please enter the first person's year of birth : ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the first person's birth month : ");
            m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the first person's birthday : ");
            d1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second person's year of birth : ");
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second person's birth month : ");
            m2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second person's birthday : ");
            d2 = int.Parse(Console.ReadLine());
            k1 = y1 * 365;
            if (m1 <= 6)
                a1 = ((m1-1) * 31) + (d1 + k1);
            else
                a1 = ((m1 - 7) * 30) + (k1 + d1 + 186);
            k2 = y2 * 365;
            if (m2 <= 6)
                a2 = ((m2-1) * 31) + (d2 + k1);
            else
                a2 = ((m2 - 7) * 30) + (k2 + 186 + d2);
            e = a1 - a2;
            Console.WriteLine("The difference is equal to " + e + " days");
            Console.ReadKey();

        }
    }
}
