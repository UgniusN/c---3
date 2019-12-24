using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaičių (sekundės): ");
            String sekLaikina = Console.ReadLine();
            int sekundes = Convert.ToInt32(sekLaikina);
            int valandos = (sekundes - (sekundes % 3600)) / 3600;
            int minutes = (((sekundes - valandos * 3600)) - ((sekundes - valandos * 3600) % 60)) / 60;
            int sekundesLikusios = sekundes - valandos * 3600 - minutes * 60;

            Console.WriteLine("{0} sekundziu tai yra: ", sekundes);
            Console.WriteLine("Valandu: {0}h;", valandos);
            Console.WriteLine("Minuciu: {0}min;", minutes);
            Console.WriteLine("Sekundziu: {0}s;", sekundesLikusios);

            Console.Read();
        }
    }
}
