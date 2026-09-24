using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio7 //Nome del progetto
{
    class Program
    {
        static void Main()
        {
            double oreLavorate, pagaOraria, pagaNetto, PagaLordo;
            const double tasse =(double) 27/100; // 27% di tasse (27/100 = 0,27)
            //usando const davanti alla variabile, questa diventa una costante, quindi non potrà essere modificata durante l'esecuzione del programma, e il suo valore rimarrà sempre lo stesso
            
            Console.Write("Inserisci le ore lavorate: ");
            oreLavorate = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Inserisci la paga oraria: ");
            pagaOraria = Convert.ToDouble(Console.ReadLine());

            PagaLordo =(double) oreLavorate * pagaOraria;           //calcolo della paga lorda (ore lavorate * paga oraria)
            pagaNetto =(double) PagaLordo - (PagaLordo * tasse);    //calcolo della paga netta (paga lorda - tasse nominali)     
            //tasse nominali = (paga lorda * 0.27) che significa il 27% della paga lorda

            Console.WriteLine("Paga Lordo: " + PagaLordo);
            Console.WriteLine("Paga Netto: " + pagaNetto);

            Console.ReadKey();
            //nn so peache ho messo P con la maiuscola a PagaLordo e pagaNetto, ma nn mi va di cambiare le variabili ora
            //sappiate che nn cambia nulla, anzi credo che vi conviene mettere le prime lettere delle variabili con la minuscola per evitare problemi una volta iniziata la programmazione a oggetti
        }
    }
}
    

