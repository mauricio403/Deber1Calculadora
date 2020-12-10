using System;
using LogicaCalculadora;

namespace CalculadoraApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Deseas usar la calculadora?");
            var respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
                Console.WriteLine("Escoje una operacion:" +
                " \n 1) Suma " +
                "\n 2) Resta" +
                " \n 3)Multiplicacion " +
                "\n 4)División " +
                "\n 5)La inversa de un número " +
                "\n 6)El cuadrado de un número" +
                "\n 7)Raíz Cuadrada");

                var eleccion = Console.ReadLine();

                if (eleccion == "1")
                {
                    Console.WriteLine("Ingrese el primer número");
                    var numero1 = Console.ReadLine();

                    Console.WriteLine("Ingrese el segundo Número");
                    var numero2 = Console.ReadLine();

                    var calculadora = new LogicaMatematica();

                    var sumaTotal = calculadora.Sumar(int.Parse(numero1), int.Parse(numero2));

                    Console.WriteLine("La suma de los 2 números es: " + sumaTotal);
                }
                if (eleccion == "2")
                {
                    Console.WriteLine("Ingrese el primer número");
                    var numero1 = Console.ReadLine();

                    Console.WriteLine("Ingrese el segundo Número");
                    var numero2 = Console.ReadLine();

                    var calculadora = new LogicaMatematica();

                    var diferencia = calculadora.Restar(int.Parse(numero1), int.Parse(numero2));

                    Console.WriteLine("La diferencia de los 2 números es: " + diferencia);

                }

                if (eleccion == "3")
                {
                    Console.WriteLine("Ingrese el primer número");
                    var numero1 = Console.ReadLine();

                    Console.WriteLine("Ingrese el segundo Número");
                    var numero2 = Console.ReadLine();

                    var calculadora = new LogicaMatematica();

                    var producto = calculadora.Multiplicar(int.Parse(numero1), int.Parse(numero2));

                    Console.WriteLine("El producto de los 2 números es: " + producto);


                }

                if (eleccion == "4")
                {
                    Console.WriteLine("Ingrese el primer número");
                    var numero1 = Console.ReadLine();

                    Console.WriteLine("Ingrese el segundo Número");
                    var numero2 = Console.ReadLine();

                    var calculadora = new LogicaMatematica();

                    var residuo = calculadora.Dividir(int.Parse(numero1), int.Parse(numero2));

                    Console.WriteLine("El residuo de la division de los 2 numeros es: " + residuo);
                }

                if (eleccion == "5")
                {
                    Console.WriteLine("Ingresa el numero que quieres ver su inversa");

                    var numero = Console.ReadLine();

                    var calculadora = new LogicaMatematica();

                    var inversa = calculadora.Inversa(double.Parse(numero));

                    Console.WriteLine("La inversa del número  " + numero + " es:  " + inversa);
                }

                if (eleccion == "6")
                {
                    Console.WriteLine("Ingrese el número que quiere ver su cuadrado");

                    var numero = Console.ReadLine();

                    var calculadora = new LogicaMatematica();

                    var cuadrado = calculadora.Cuadrado(int.Parse(numero));

                    Console.WriteLine("El cuadrado del número " + numero + " es " + cuadrado);

                }

                if (eleccion == "7")
                {
                    Console.WriteLine("Ingrese el número al que desea calcular su raíz cuadrada");

                    var numero = Console.ReadLine();

                    var calculadora = new LogicaMatematica();

                    var raiz = calculadora.Raiz(double.Parse(numero));

                    Console.WriteLine("La raíz del numero " + numero + " es " + raiz);
                }
                

                Console.WriteLine("Deseas volver a usar la calculadora?");
                respuesta = Console.ReadLine();
            }

          

        }
    }
}
