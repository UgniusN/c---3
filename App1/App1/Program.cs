using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda: ");
            String vardas = Console.ReadLine();
            Console.WriteLine("Iveskite pavarde: ");
            String pavarde = Console.ReadLine();
            String vardasDid = vardas.ToUpper();
            String pavardeDid = pavarde.ToUpper();
            Console.WriteLine("{0}_{1}",vardasDid,pavardeDid);
            Console.ReadLine();
        }
    }
}
