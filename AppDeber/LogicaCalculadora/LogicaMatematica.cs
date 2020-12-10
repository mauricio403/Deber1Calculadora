using System;

namespace LogicaCalculadora
{
    public class LogicaMatematica
    {
        public int Sumar(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }

        public int Restar(int minuendo, int sustraendo)
        {
            return minuendo - sustraendo;
        }

        public int Multiplicar(int factor1, int factor2)
        {
            return factor1 * factor2;
        }

        public int Dividir(int dividendo, int divisor)
        {
            return dividendo / divisor;
        }

        public double Inversa( double numero)
        {
            return  1 / numero;
        }

        public int Cuadrado( int numero)
        {

            return numero * numero;
        }

        public double Raiz ( double numero)
        {
            return Math.Sqrt(numero);

            
            
        }
    }
}
