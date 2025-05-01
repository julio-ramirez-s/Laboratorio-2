using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBucle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            float num1, num2, suma, resta, division, multiplicacion;


            Console.WriteLine("----MENU----");
            Console.WriteLine("1, SUMA");
            Console.WriteLine("2, RESTA");
            Console.WriteLine("3, DIVISIÓN");
            Console.WriteLine("4, MULTIPLICACIÓN");
            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:

                    Console.WriteLine("Ingrese el primer numero: ");
                    num1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo numero: ");
                    num2 = float.Parse(Console.ReadLine());

                    suma = num1 + num2;

                    Console.WriteLine("El resultado es: "+ suma);
                    Console.ReadLine();

                    break;

                case 2:

                    Console.WriteLine("Ingrese el primer numero: ");
                    num1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo numero: ");
                    num2 = float.Parse(Console.ReadLine());

                    resta = num1 - num2;

                    Console.WriteLine("El resultado es: " + resta);
                    Console.ReadLine();

                    break;

                case 3:

                    Console.WriteLine("Ingrese el primer numero: ");
                    num1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo numero: ");
                    num2 = float.Parse(Console.ReadLine());

                    division = (num1) / (num2);

                    Console.WriteLine("El resultado es: " + division);
                    Console.ReadLine();

                    break;

                case 4:

                    Console.WriteLine("Ingrese el primer numero: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo numero: ");
                    num2 = int.Parse(Console.ReadLine());

                    multiplicacion = num1 * num2;

                    Console.WriteLine("El resultado es: " + multiplicacion);
                    Console.ReadLine();

                    break;

                default:
                    break;
            }


        }
    }
}
