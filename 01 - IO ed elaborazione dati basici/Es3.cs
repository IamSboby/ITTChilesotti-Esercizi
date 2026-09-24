using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3 //Nome del progetto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            double media;

            Console.Write("Inserire primo numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInserire secondo numero: "); //con \n andiamo a capo prima di scrivere
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInserire terzo numero: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            media =(double) (n1 + n2 + n3) / 3; //inserendo (double) prima della parentesi, si forza il calcolo a essere in double (quindi numeri reali) cosi da poter permettere risultati con la ","

            Console.Write("\nLa media aritmetica è uguale a: " +media); //unaltro modo per mettere variabili al momento della scrittura a console è con il simbolo +, che "concatena" (attaca una dietro l'altra) la stringa con la variabile
            
            Console.ReadKey(); //ricordiamo sempre di mettere Console.ReadKey() alla fine del programma, altrimenti la console si chiude subito dopo aver eseguito il programma e non ci permette di vedere il risultato
        }
    }
}
