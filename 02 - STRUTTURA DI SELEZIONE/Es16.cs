using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio16 //Nome del progetto
{
	class Program
	{
		static void Main()
		{
			Console.Write("Inserisci il primo lato: ");
			double lato1 = Convert.ToDouble(Console.ReadLine()!);       //introduciamo il "!" alla fine di Console.ReadLine()
			Console.Write("Inserisci il secondo lato: ");
			double lato2 = Convert.ToDouble(Console.ReadLine()!);       //se metitamo un punto esclamativo alla fine di Console.ReadLine()
			Console.Write("Inserisci il terzo lato: ");
			double lato3 = Convert.ToDouble(Console.ReadLine()!);       //diciamo al computer che il valore non puo essere null (vuoto)

			//molto utile in programmi dove se il programma va avanti con variabili vuote, rischia di sminchiare tt
			//!NB: VUOTE NON VUOLE DIRE "0", vuol dire che nella varibile non ce NIENTE

			//prima delle condizioni propio alla base per vedere se si puo fare il triangolo
			if (lato1 <= 0 || lato2 <= 0 || lato3 <= 0 ||                                           //se anche solo uno dei lati è minore o uguale a 0 non è possibile costruire un triangolo
				lato1 + lato2 <= lato3 || lato1 + lato3 <= lato2 || lato2 + lato3 <= lato1)         //se la somma di due lati è minore o uguale al terzo lato same di sopra non posso costruire un triangolo
			{
				Console.WriteLine("Con queste misure non è possibile costruire un triangolo.");
				return;
			}


			//poi vediamo chetipo di triangolo sono
			if (lato1 == lato2 && lato2 == lato3)
				Console.WriteLine("Il triangolo è equilatero.");            //se tutti e tre i lati sono uguali allora il triangolo è equilatero
																			//seguendo algebra: se A = B e B = C allora A = C
			else if (lato1 == lato2 || lato1 == lato3 || lato2 == lato3)
				Console.WriteLine("Il triangolo è isoscele.");              //se due dei lati sono uguali allora il triangolo è isoscele
			else
				Console.WriteLine("Il triangolo è scaleno.");               //in tutti gli altri casi il triangolo è scaleno (nessun lato uguale)

			//ultimo passo: vediamo se il triangolo è rettangolo
			if (Math.Pow(lato1, 2) + Math.Pow(lato2, 2) == Math.Pow(lato3, 2) ||        //Usiamo la formula di Pitagora: a^2 + b^2 = c^2, dove c è l'ipotenusa (il lato più lungo)
				Math.Pow(lato1, 2) + Math.Pow(lato3, 2) == Math.Pow(lato2, 2) ||        //dato che non sappiamo quale lato sia l'ipotenusa
				Math.Pow(lato2, 2) + Math.Pow(lato3, 2) == Math.Pow(lato1, 2))          //dobbiamo fare ttutte le controllare tutte le possibilita
			{
				Console.WriteLine("Il triangolo è rettangolo.");
			}
			else
			{
				Console.WriteLine("Il triangolo non è rettangolo.");
			}
			
			Console.ReadKey();
			
			
			/* determinare se il triangolo è rettangolo per ultrafighi tuff aura (molto più difficile da capire se nn avete esperienza con array e funzioni):

			double[] lati = { lato1, lato2, lato3 };                                                //*creiamo un array di double chiamato lati e ci mettiamo dentro i tre lati del triangolo
			Array.Sort(lati);                                                                       //*Array.Sort() ordina l'array in ordine crescente, quindi il lato più lungo sarà sempre l'ultimo elemento dell'array (lati[2])
			if ((Math.pow(lati[0], 2) + Math.pow(lati[1], 2) - Math.pow(lati[2], 2)) <= 0)          //*Math.pow() eleva un numero a una potenza, quindi in questo caso elevo i lati al quadrato.
				Console.WriteLine("Il triangolo è rettangolo.");                                    //*Se la differenza è 0, allora i tre lati soddisfano la formula di Pitagora e il triangolo è rettangolo
			else
				Console.WriteLine("Il triangolo non è rettangolo.");                                //*Se non è 0, allora i tre lati non soddisfano la formula di Pitagora e il triangolo non è rettangolo

				?questi 2 programi possono sbagliare nel caso di risultati con la virgola mobile ("floating point" se volete cercarlo pk in italiano ci son poche spiegazioni decenti), Manco io so pk ma so che certi numeri binari si sballano potente e viene un numero stra random
			*/
		}
	}
}