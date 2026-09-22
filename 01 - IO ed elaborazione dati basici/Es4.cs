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
            double Base, Altezza;

            Console.Write("Inserire Base: ");
            Base = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nInserire Altezzza: ");
            Altezza = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nIl perimetro è uguale a: " + ((Base*2)+(Altezza*2)));
            Console.Write("\nL' area è uguale a: " + (Base*Altezza));
            Console.ReadKey();
        }
    }
}
