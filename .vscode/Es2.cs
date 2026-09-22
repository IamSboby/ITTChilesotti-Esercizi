using System;

class Program
{
    static void Main()
    {
        Console.Write("Inserisci il primo numero reale: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Inserisci il secondo numero reale: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double somma = a + b;
        double differenza = a - b;
        double prodotto = a * b;
        double quoziente = a / b; // supponiamo b diverso da zero

        Console.WriteLine($"Somma: {somma} \nDifferenza: {differenza} \nProdotto: {prodotto} \nQuoziente: {quoziente}");
    }
}

//il programma credo non usi certe librerie come su visual studio dato che io uso gia da anni VS Code e ho usato direttamente quello