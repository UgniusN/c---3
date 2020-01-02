using System;
using System.Drawing;
using System.Windows;
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

            String x1 = Console.ReadLine();
            int X1 = Convert.ToInt32(x1);

            String y1 = Console.ReadLine();
            int Y1 = Convert.ToInt32(y1);

            Console.WriteLine("Iveskite antras staciakampio (X1;Y1) Koordinates: ");

            String x2 = Console.ReadLine();
            int X2 = Convert.ToInt32(x2);

            String y2 = Console.ReadLine();
            int Y2 = Convert.ToInt32(y2);

            Console.WriteLine("Iveskite taska(x;y)");
            String x3 = Console.ReadLine();
            int x = Convert.ToInt32(x3);

            String y3 = Console.ReadLine();
            int y = Convert.ToInt32(y3);

            var taskoPozicija = (x > X1 && x < X2 && y > Y1 && y < Y2);

            Console.WriteLine("Ar taskas staciakampio viduje? {0}",taskoPozicija);

            Console.Read();
        }
    }
}
