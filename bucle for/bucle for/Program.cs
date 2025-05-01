using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciobucle
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                int numero;
                int num1, num2, suma, resta, mult;
                double div, numero1, numero2;

                Console.WriteLine("----MENU----");
                Console.WriteLine("1. SUMA");
                Console.WriteLine("2. RESTA");
                Console.WriteLine("3. DIVISION");
                Console.WriteLine("4. MULTIPLICACION");
                numero = int.Parse(Console.ReadLine());

                switch (numero)
                {
                    case 1:

                        Console.WriteLine("Ingrese el primer numero: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo numero: ");
                        num2 = int.Parse(Console.ReadLine());

                        suma = num1 + num2;

                        Console.WriteLine("El resultado es: " + suma);
                        Console.ReadLine();

                        break;

                    case 2:

                        Console.WriteLine("Ingrese el primer numero: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo numero: ");
                        num2 = int.Parse(Console.ReadLine());

                        resta = num1 - num2;

                        Console.WriteLine("El resultado es: " + resta);
                        Console.ReadLine();
                        break;

                    case 3:

                        Console.WriteLine("Ingrese el primer numero: ");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo numero: ");
                        numero2 = double.Parse(Console.ReadLine());

                        div = numero1 / numero2;

                        Console.WriteLine("El resultado es: " + div);
                        Console.ReadLine();

                        break;

                    case 4:

                        Console.WriteLine("Ingrese el primer numero: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo numero: ");
                        num2 = int.Parse(Console.ReadLine());

                        mult = num1 * num2;

                        Console.WriteLine("El resultado es: " + mult);
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("El numero ingresado no es valido.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}