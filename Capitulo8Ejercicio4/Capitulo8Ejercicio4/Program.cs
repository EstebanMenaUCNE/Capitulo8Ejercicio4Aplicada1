using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo8Ejercicio4
{
    class Program
    {
        //Hacer un programa que calcule sumas y muestre los resultados negativos entre paréntesis.

        static void Main(string[] args)
        {
            Console.Write("Digite el primer numero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el segundo numero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int suma = n1 + n2;
            string resultado = "";
            if (suma > 0)
                resultado = suma.ToString();
            else
                resultado = "(" + suma + ")";

            Console.WriteLine("La suma es igual a " + resultado);
            Console.ReadKey();

        }
    }
}
