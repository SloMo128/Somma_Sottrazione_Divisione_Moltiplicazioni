using System;

namespace Somma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inserisci il primo numero");
            double a = Convert.ToDouble(Console.ReadLine()); //Converte da stringa in double

            Console.WriteLine("Inserisci il secondo numero");
            double b = Convert.ToDouble(Console.ReadLine());

            double somma = a + b;
            double sottrazione = a - b;
            double divisione = a / b;
            double moltiplicazione = a * b;

            Console.WriteLine("La somma è: " + somma);
            Console.WriteLine("La sottrazione è: " + sottrazione);
            Console.WriteLine("La divisione è: " + divisione);
            Console.WriteLine("La moltiplicazione è: " + moltiplicazione);

            Console.Read();
        }
    }
}
