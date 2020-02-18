using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(0,0,1);
            TimeSpan t3 = TimeSpan.FromDays(1,5);
                
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t2.Ticks);
            Console.WriteLine(t3);
            Console.ReadKey();
        }
    }
}
