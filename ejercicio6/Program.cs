﻿using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. Hacer un programa que solicite UN número y luego calcule y emita un cartel
            // aclaratorio si el mismo es primo o no es primo.
            // Nota: un numero es primo cuando es divisible únicamente por 1 y por sí
            // mismo.

            int num, con=0;

            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());

            for (int x = 1; x <= num; x++)
            {
                if( num % x == 0)
                    con++;
            }

            if ( con== 2)
                Console.WriteLine("El numero es primo");
            else Console.WriteLine("El numero no es primo");
        }
    }
}
