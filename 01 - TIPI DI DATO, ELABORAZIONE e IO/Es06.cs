using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio6 //Nome del progetto
{
    class Program
    {
        static void Main(string[] args)
        {
            double VarA, VarB, TempVar;

            Console.Write("Inserire primo numero: ");
            VarA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserire primo numero: ");
            VarB = Convert.ToDouble(Console.ReadLine());

            //per fare lo "swap" delle variabili, dobbiamo creare una variabile temporanea che ci permetta di salvare il valore di una delle due variabili, altrimenti quando andremo a fare l'assegnazione della prima variabile alla seconda, perderemo il valore della seconda variabile e quindi non potremo più assegnarlo alla prima variabile

            TempVar = VarB;     //salviamo il valore della variabile B nella variabile temporanea
            VarB = VarA;        //assegniamo il valore della variabile A alla variabile B
            VarA = TempVar;     //assegniamo il valore della variabile temporanea (che contiene il valore della variabile B) alla variabile A

            Console.WriteLine("Dopo lo swap:\nVarA = " + VarA + "\nVarB = " + VarB);

            Console.ReadKey();
        }
    }
}
