using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio17 //Nome del progetto
{
    class Program
    {
        static void Main(string[] args)
        {
            //la variabile di tipo long è un intero ma che puo contenere numeri molto più grandi di un int normale (int usa 32 bit mentre long usa 64 bit)

            long n1, d1, n2, d2;            //dato che sono un casino di variabili, definiamole sopra per ordine
            
            Console.WriteLine("Inserire i dati della prima frazione:");
            
            Console.Write("N1: ");
            n1 = Convert.ToInt64(Console.ReadLine());

            do
            {
                Console.Write("D1: ");
                d1 = Convert.ToInt64(Console.ReadLine());
            } while (d1 == 0);

            
            
            Console.WriteLine("Inserire i dati della seconda frazione:");

            Console.Write("N2: ");
            n2 = Convert.ToInt64(Console.ReadLine());

            do
            {
                Console.Write("D2: ");
                d2 = Convert.ToInt64(Console.ReadLine());
            } while (d2 == 0);



            // Cambiamo i segni delle frazioni in modo che il denominatore sia sempre positivo
            if (d1 < 0)
            {
                n1 = -n1;
                d1 = -d1;
            }

            if (d2 < 0)
            {
                n2 = -n2;
                d2 = -d2;
            }

            do
            {
                Console.WriteLine();
                Console.WriteLine("1 - Indicare la frazione maggiore");
                Console.WriteLine("2 - Calcolare la somma");
                Console.WriteLine("3 - Calcolare il prodotto");
                Console.WriteLine("0 - Esci");
                Console.Write("Scelta: ");
                int scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        long confronto1 = n1 * d2;      //confronto1 = n1 * d2, confronto2 = n2 * d1
                        long confronto2 = n2 * d1;      //quindi se confronto1 > confronto2 allora la prima frazione è maggiore della seconda
                        if (confronto1 > confronto2)
                            Console.WriteLine("La frazione maggiore è {0}/{1}.", n1, d1);
                        else if (confronto2 > confronto1)
                            Console.WriteLine("La frazione maggiore è {0}/{1}.", n2, d2);
                        else
                            Console.WriteLine("Le due frazioni sono uguali.");
                        break;

                    case 2:
                        Console.WriteLine("Somma: {0}/{1}.", n1 * d2 + n2 * d1, d1 * d2);
                        break;

                    case 3:
                        Console.WriteLine("Prodotto: {0}/{1}.", n1 * n2, d1 * d2);
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }
            } while (scelta != 0);      //nel caso la scelta è diversa da 0, il programma continua a girare, altrimenti esce
        }
    }
}
