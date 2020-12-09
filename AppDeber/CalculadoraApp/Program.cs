using System;
using LogicaCalculadora;

namespace CalculadoraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número");
            var numero1 = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo Número");
            var numero2 = Console.ReadLine();

            var calculadora = new LogicaMatematica();

            var sumaTotal = calculadora.Sumar(int.Parse(numero1), int.Parse(numero2));

            Console.WriteLine("La suma de los 2 numeros es: " + sumaTotal);
        }
    }
}
