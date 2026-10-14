using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio13 //Nome del progetto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il primo numero: ");
            double Num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserisci il secondo numero: ");
            double Num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserisci il terzo numero: ");
            double Num3 = Convert.ToDouble(Console.ReadLine());

            //confronto i tre numeri per trovare il maggiore
            if (Num1 > Num2 && Num1 > Num3)         //!Se Num1 è maggiore di Num2 e Num3 allora stampo Num1
            {
                Console.WriteLine("Il numero maggiore è: " + Num1);
            }
            else if (Num2 > Num1 && Num2 > Num3)    //!Se Num2 è maggiore di Num1 e Num3 allora stampo Num2
            {
                Console.WriteLine("Il numero maggiore è: " + Num2);
            }
            else                                    //!in tutti gli altri casi stampo Num3
            {
                Console.WriteLine("Il numero maggiore è: " + Num3);
            }


            Console.ReadKey();
        }
    }
}