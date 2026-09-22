using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari
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

            TempVar = VarB;
            VarB = VarA;
            VarA = TempVar;

            Console.ReadKey();
        }
    }
}
