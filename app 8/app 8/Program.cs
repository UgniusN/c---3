using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite staciakampio (X;Y) Koordinates: ");

            String x = Console.ReadLine();
            int X = Convert.ToInt32(x);

            String y = Console.ReadLine();
            int Y = Convert.ToInt32(y);

            Console.WriteLine("Iveskite antro staciakampio (X1;Y1) Koordinates: ");

            String x1 = Console.ReadLine();
            int X1 = Convert.ToInt32(x1);

            String y1 = Console.ReadLine();
            int Y1 = Convert.ToInt32(y1);
        }
    }
}
