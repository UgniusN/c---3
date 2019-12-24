using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite krastines x ilgi: ");
            String ilgisLaik = Console.ReadLine();
            double ilgisDid = Convert.ToDouble(ilgisLaik);

            Console.WriteLine("Iveskite krastines y ploti: ");
            String plotisLaik = Console.ReadLine();
            double plotisDid = Convert.ToDouble(plotisLaik);

            double plotasDid = ilgisDid * plotisDid;
            double ilgisMaz = 2;
            double plotisMaz = 3;
            double plotasMaz = ilgisMaz * plotisMaz;

            double kiekis = Math.Round(plotasDid / plotasMaz, 0);

            Console.WriteLine("Į {0} x {0} staciakampi {2} x {3} staciakampiu tilps: {4}",ilgisDid,plotisDid,ilgisMaz,plotisMaz,kiekis);

            Console.Read();
        }
    }
}
