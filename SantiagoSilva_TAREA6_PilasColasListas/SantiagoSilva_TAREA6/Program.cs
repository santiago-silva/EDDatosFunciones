using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace SantiagoSilva_TAREA5
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean ingreso;
            Program practica = new Program();

            ingreso = practica.Pilas();
            Console.ReadKey();

            ingreso = practica.Colas();
            Console.ReadKey();

            practica.Lista();
            Console.ReadKey();
        }

        public void Lista()
        {
            List<String> l = new List<string>();

            Console.WriteLine("ingrese una frase o nada para salir");
            String input = Console.ReadLine();

            while (input != "")
            {
                l.Add(input);

                Console.WriteLine("ingrese una frase o nada para salir");
                input = Console.ReadLine();
            }

            foreach (String str in l)
            {
                Console.WriteLine(str);
            }

        }

        public Boolean Colas()
        {
            Queue cola = new Queue();

            for (int i = 0; i < 7; i++)
            {

                Console.WriteLine("Ingrese un número real de dos decimales");
                float num = float.Parse(Console.ReadLine());

                cola.Enqueue(num);
            }

            Console.WriteLine("Cola creada con éxito!");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(cola.Dequeue());
            }

            return true;
        }


        public Boolean Pilas()
        {
            Stack pila = new Stack();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingrese un número entero: ");
                int numero = int.Parse(Console.ReadLine());

                pila.Push(numero);
            }

            Console.WriteLine("Se ha creado la pila con éxito!");

            for (int c = 0; c < 6; c++)
            {
                Console.WriteLine(pila.Pop());
            }

            return true;
        }
    }
}