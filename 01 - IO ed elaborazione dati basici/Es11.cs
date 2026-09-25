using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio11 //Nome del progetto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                in questo esercizio usiamo per prima volta l'operatore "modulo" %
                L' operatore modulo restituisce il resto della divisione tra due numeri
                
                Esempio:
                5 % 2 = 1
                5 % 3 = 2
                10 % 5 = 0
                
                È utile anche per capire se un numero è pari o dispari, infatti:
                4 % 2 = 0 quindi 4 è pari
                5 % 2 = 1 quindi 5 è dispari

                In questo caso lo usiamo per capire se il secondo numero è multiplo del primo, 
                Se il secondo numero è multiplo del primo, il resto della divisione tra i due numeri sarà 0
             */
            
            Console.Write("Inserisci il primo numero intero: ");
            int primo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserisci il secondo numero intero: ");
            int secondo = Convert.ToInt32(Console.ReadLine());

            if (primo != 0 && secondo % primo == 0) 
            {
                //questo if è a multiple condizioni, il && significa "E" (stesa logica della matematica booleana)
                //come prima condizione (primo != 0) controlliamo che il primo numero non sia 0 (sembrano dettagli superflui ma un errore come non mettere n diverso da 0 può portare a un errore di divisione per 0)
                //come seconda condizione (secondo % primo == 0) controlliamo che il secondo numero sia multiplo del primo

                Console.WriteLine("Il secondo numero è multiplo del primo.");
            }
            else
            {
                Console.WriteLine("Il secondo numero non è multiplo del primo.");
            }

            Console.ReadKey(); //Aspettiamo che l'utente prema un tasto prima di chiudere il programma
        }
    }
}
