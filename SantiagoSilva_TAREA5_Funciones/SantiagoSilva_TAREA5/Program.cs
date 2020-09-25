using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace SantiagoSilva_TAREA5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero entero: ");
            int entry = int.Parse(Console.ReadLine());

            int resultado = Program.Signo(entry);

            Console.WriteLine(resultado);

            Console.WriteLine("Ingrese un número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            resultado = Program.Menor(num1, num2);
            Console.WriteLine(resultado);
            Console.ReadKey();

            Console.WriteLine("Ingrese un número para verificar si es primo: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Program.EsPrimo(num));

            Program.Dibujo();
            Console.ReadKey();
        }

        /*
         * La función dibuja "media pirámide" de "*" a medida que avanza en las líneas.
         * Comienza con la línea 1 y dibuja "*" según la fórmula "(número de línea * 2) -1". Para la primer línea, el valor es 1, por lo que dibuja 6 líneas con un solo "*".
         * A medida que avanza en el ciclo, avanza el número de línea, por lo que también aumenta la cantidad de "*" (número de línea * 2 - 1). Pero, a su vez, decrece la 
         * cantidad de líneas que dibuja en 1. En la segunda iteración, en vez de escribir 6 líneas, se escriben 5 (y así de forma consecutiva).
         * Finalmente se escribe una sola línea con 11 "*" [(6 * 2) -1] = 11.
         */
        static void Dibujo()
        {
            Console.Clear();

            for (int fila = 1; fila <= 7; fila++)
            {
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                {
                    Console.Write(" ");

                    for (int conta = 1; conta < (2 * fila); conta++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(" ");
                }
            }
        }

        static Boolean EsPrimo(int input)
        {
            int contador = 0;

            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    contador++;
                }
            }

            return contador == 2;
        }

        static int Menor(int num1, int num2)
        {
            int menor;

            if (num1 < num2)
            {
                menor = num1;
            }
            else
            {
                menor = num2;
            }

            return menor;
        }

        static int Signo(float num)
        {
            if (num == 0)
            {
                return 0;
            } else if (num > 0)
            {
                return 1;
            } else
            {
                return -1;
            }
        }
    }
}