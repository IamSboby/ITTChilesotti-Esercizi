using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            double media;

            Console.Write("Inserire primo numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInserire secondo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInserire terzo numero: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            media =(double) (n1 + n2 + n3) / 3;

            Console.Write("\nLa media aritmetica è uguale a: " +media);
            Console.ReadKey();
        }
    }
}
