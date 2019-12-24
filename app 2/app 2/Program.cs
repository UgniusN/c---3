using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite apskritimo spinduli(r): ");
            String r = Console.ReadLine();
            int radius = Convert.ToInt32(r);
            double ilgis = 2 * radius * Math.PI;
            double plotas = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Apskritimo spindulys = {0};",radius);
            Console.WriteLine("Apskritimo plotas = {0};", plotas);
            Console.WriteLine("Apskritimo ilgis = {0};", ilgis);
            Console.ReadLine();
        }
    }
}
