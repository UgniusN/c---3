using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite dvizenklį skaičių: ");
            String dvizenklisLaik = Console.ReadLine();
            int dvizenklis = Convert.ToInt32(dvizenklisLaik);
            int vienetai = dvizenklis % 10;
            int desimtys = (dvizenklis - vienetai) / 10;
            int skaitmenuSuma = vienetai + desimtys;
            Console.WriteLine("Dviženklio skaiciaus {0} skaitmenu suma yra {1} + {2} = {3}", dvizenklis,desimtys, vienetai, skaitmenuSuma);

            Console.Read();
        }
    }
}
