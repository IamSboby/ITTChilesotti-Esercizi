using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio10 //Nome del progetto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                In questo esercizio usiamo per la prima volta l'istruzione "if" che ci permette di eseguire del codice solo se una condizione è vera o falsa
                in altre parole i rombo dei diagrammi di flusso,

                usando la istruzzione else possiamo anche eseguire del codice se la condizione è falsa (quella che sarebbe il no)
             */
            Double prezzo, soldiScontati; //double pk possono essere numeri con la virgola, quindi nuemri reali

            Console.WriteLine("Inserisci il prezzo del prodotto: ");
            prezzo = Convert.ToDouble(Console.ReadLine());

            if (prezzo < 0)         //Controlliamo se il prezzo è negativo
            {
                Console.WriteLine("Il prezzo non può essere negativo.");
            }
            else                    //se il prezzo è positivo, calcoliamo lo sconto
            {

                if (prezzo <= 1000) //Se il prezzo è minore o uguale a 1000, lo sconto sarà del 3%
                {
                    soldiScontati = prezzo * 0.03; //0.03 quindi 3/100
                }

                else                //in tutti gli altri casi, lo sconto sarà del 5%
                {
                    soldiScontati = prezzo * 0.05; //0.05 quindi 5/100
                }

                Console.WriteLine("Il prezzo scontato è: " + (prezzo - soldiScontati));    //Stampiamo il prezzo scontato
                Console.WriteLine("Hai risparmiato: " + soldiScontati);                    //Stampiamo quanto abbiamo risparmiato

                //in questo esercizio potevamo anche non creare la variabile soldiScontati
            }

            Console.ReadLine(); //Aspettiamo che l'utente prema un tasto prima di chiudere il programma

            //questo esercizio si poteva fare con un if a più condizioni ma lo lascio cosi, cosi è più facile da capire
        }
    }
}
