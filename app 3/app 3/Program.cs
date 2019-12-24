using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite DARBUOTOJO ID: ");
            String ivestisId = Console.ReadLine();
            int ID = Convert.ToInt32(ivestisId);

            Console.WriteLine("Iveskite DARBUOTOJO ISDIRBTAS VALANDAS");
            String ivestisValandos = Console.ReadLine();
            int valandos = Convert.ToInt32(ivestisValandos);

            Console.WriteLine("Iveskite DARBUOTOJO VALANDINI IKAINI ( EUR / H )");
            String ivestisIkainis = Console.ReadLine();
            double ikainis = Convert.ToDouble(ivestisIkainis);

            double alga = valandos * ikainis;
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Darbuotojo ID: {0}", ID);
            Console.WriteLine("Darbuotjo ALGA: {0}", alga);
            Console.ReadLine();
        }
    }
}
