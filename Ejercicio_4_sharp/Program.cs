using System;

namespace Ejercicio_4_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca una temperatura en grados Fahrenheit: ");
            decimal fahrenheit = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = (5m/9m) * (fahrenheit-32);

            Console.WriteLine(fahrenheit + " grados Fahrenheit equivalen a " + Math.Round(resultado, 2) + " grados Celsius.");
        }
    }
}
