using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StampaNome //Nome del progetto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il primo numero reale: ");
            double a = Convert.ToDouble(Console.ReadLine()); //con Console.ReadLine() leggo una stringa (variabile che contiene i dati come se fossero testo) da console

            Console.Write("Inserisci il secondo numero reale: ");
            double b = Convert.ToDouble(Console.ReadLine()); //poi con Convert.ToDouble() converto la stringa letta da Console.ReadLine() in un numero reale (double, che contiene i dati salvati come se fossero numeri)

            double somma = a + b;           //sommiamo i due numeri
            double differenza = a - b;      //sottraiamo i due numeri
            double prodotto = a * b;        //moltiplichiamo i due numeri
            double quoziente = a / b;       //dividiamo i due numeri supponendo che b diverso è da zero

            Console.WriteLine($"Somma: {somma} \nDifferenza: {differenza} \nProdotto: {prodotto} \nQuoziente: {quoziente}");
            
            Console.Read();
        }
    }
}
