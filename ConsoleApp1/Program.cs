using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoeda conversor = new ConversorDeMoeda();

            Console.WriteLine("A cotação é 5.00");
           
            Console.WriteLine("Quantos dólares você vai comprar?");
            conversor.Dolar = double.Parse(Console.ReadLine());

            Console.WriteLine(conversor);
        }
    }
}
