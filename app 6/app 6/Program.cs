using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu A: ");
            String a = Console.ReadLine();
            double A = Convert.ToDouble(a);

            Console.WriteLine("Iveskite skaiciu B: ");
            String b = Console.ReadLine();
            double B = Convert.ToDouble(b);

            Console.WriteLine("Dabar skaicius A yra: {0}, o skaicius B yra {1}", A,B);

            A += B;
            B = A - B;
            A -= B;

            Console.WriteLine("Dabar skaicius A yra: {0}, o skaicius B yra {1}", A, B);

            Console.ReadLine();
        }
    }
}
