using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio8 //Nome del progetto
{
    class Program
    {
        static void Main()
        {
            //possiamo anche dichiarare i valori delle variabili nella stessa riga in cui le inizializziamo, quindi senza dover fare prima "int variabile;" e poi "variabile = valorevariabile;"

            const int prezzoOlioNormale = 15, prezzoOlioPremium = 20; //un' esempio pratico

            Console.Write("Inserisci i litri di olio da acquistare: ");
            double litriPartitaOlio = Convert.ToDouble(Console.ReadLine()); //ma non solo, possiamo anche fare questo trucco con gli input

            double prezzoSpesa =(double) ((litriPartitaOlio*prezzoOlioNormale)+(litriPartitaOlio * prezzoOlioPremium));

            Console.WriteLine("Prezzo della spesa:" + prezzoSpesa);

            Console.ReadKey();
        }
    }
}
