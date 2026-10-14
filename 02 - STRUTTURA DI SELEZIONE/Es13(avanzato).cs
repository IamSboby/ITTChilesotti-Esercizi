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

            int max = Math.Max(Num1, Math.Max(Num2, Num3));                  //*Math.Max() prende 2 (non più) numeri e ti restituisce il maggiore
            Console.WriteLine("Il numero maggiore è: " + max);      //*Quindi seguedo logica algerbraica: se Num1 > Num2 e Num2 > Num3 allora Num1 > Num3
            
            Console.ReadKey();
        }
    }
}