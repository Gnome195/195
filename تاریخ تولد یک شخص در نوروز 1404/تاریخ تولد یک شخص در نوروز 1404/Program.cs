using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace تاریخ_تولد_یک_شخص_در_نوروز_1404
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y, m, d, r, r1, r2;
            Console.WriteLine("ple enter years of birth : ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("ple enter month of birth : ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("ple enter birth days : ");
            d = int.Parse(Console.ReadLine());
            r1 = (1404 - y - 1) * 365;
            if (m <= 6)
                r2 = 365 - ((m - 1) * 31 + d);
            else
                r2 = 365 - (186 + (m - 7) * 30 + d);
            r = r1 + r2;
            Console.WriteLine("You have lived  '"+r+"' days.");
            y = r / 365;
            m = (r% 365) / 30;
            d = ((r % 365) % 30);
            Console.WriteLine(y+" years and "+m+" month and "+d+" deys");
            Console.ReadKey();

                    
                    
        }
    }
}
