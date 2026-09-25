using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio12 //Nome del progetto 
{
    class Program
    {
        static void Main(string[] args)
        {
            double kmPercorsi, pagamentoKm, pagamentoFisso, costoBenzina;

            Console.Write("Inserisci i km percorsi: ");
            kmPercorsi = Convert.ToDouble(Console.ReadLine());

            if (kmPercorsi < 0)     //come sempre controlliamo che i km percorsi non siano negativi, altrimenti il programma non avrebbe senso
            {
                Console.WriteLine("I km percorsi non possono essere negativi.");
            }
            else                    //se i km percorsi sono positivi, calcoliamo il costo della benzina e i due metodi di pagamento
            {
                costoBenzina = 1.75 * (kmPercorsi / 15);    //calcoliamo il costo della benzina, considerando che il costo per ogni 15km è di 1.75 €
                pagamentoKm = kmPercorsi;                   //questo passaggio non è strettamente necessario ma molto consigliato per evitare confusione
                pagamentoFisso = 100;                       //il pagamento fisso è di 100 €

                //Dato che il costo della benzina viene rimborsato dai soldi che noi spendiamo si annumllano a vicenda, quindi il pagamento fisso sarà sempre 100 € più il costo della benzina
                
                if (pagamentoKm == pagamentoFisso) //non si sa mai e forse i due metodi di pagamento sono equivalenti, quindi controlliamo anche questa possibilità
                {
                    Console.WriteLine("I due metodi di pagamento sono equivalenti.");
                }

                else if (pagamentoKm > pagamentoFisso) //controlliamo se il pagamento a km è maggiore del pagamento fisso
                { 
                    /*
                    else if è un'istruzione che ci permette di fare un if dentro un altro if
                    in questo caso controlliamo se il pagamento a km è maggiore del pagamento fisso
                    ma si eseguira solo se il primo if (pagamentoKm == pagamentoFisso) è falso

                    questa cosa sara ESTREMAMENTE utile in futuro quando faremo programmi più complessi, per ora ci basta sapere che esiste
                    */

                    Console.WriteLine("Conviene di più il pagamento a km.");
                }
                
                else //lunica opzione rimasta è che il pagamento a km sia minore del pagamento fisso, quindi non serve controllare nulla
                {
                    Console.WriteLine("Conviene di più il pagamento fisso di 100 € più il rimborso della benzina.");
                }

                //stampiamo dei risultati unificati per poter chiarire la decisione finale presa dal programma

                Console.WriteLine("\nIl pagamento a km è: " + pagamentoKm + " €");
                Console.WriteLine("Il pagamento fisso più il rimborso è: " + pagamentoFisso + " €");
                Console.WriteLine("Il costo della benzina è: " + costoBenzina + " €");
            }
        }
    }
}