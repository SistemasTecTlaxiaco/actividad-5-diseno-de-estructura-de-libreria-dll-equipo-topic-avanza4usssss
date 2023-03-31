using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calcucientific;
namespace Pruebacalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            double a, b, resultado;
            int opcion;
            Boolean valor = true;

            while (valor)
            {
                Console.WriteLine("Calculadora Básica");
                Console.WriteLine("------------------");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Raíz Cuadrada");
                Console.WriteLine("6. Logaritmo");
                Console.WriteLine("7. Seno");
                Console.WriteLine("8. Coseno");
                Console.WriteLine("9. Tangente");
                Console.WriteLine("10. Salir");
                Console.WriteLine();

                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el primer número: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        b = double.Parse(Console.ReadLine());
                        resultado = obj.Sumar(a, b);
                        Console.WriteLine("El resultado de la suma es: {0}", resultado);
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("Ingrese el primer número: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        b = double.Parse(Console.ReadLine());
                        resultado = obj.Restar(a, b);
                        Console.WriteLine("El resultado de la resta es: {0}", resultado);
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("Ingrese el primer número: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        b = double.Parse(Console.ReadLine());
                        resultado = obj.Multiplicar(a, b);
                        Console.WriteLine("El resultado de la multiplicación es: {0}", resultado);
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write("Ingrese el primer número: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        b = double.Parse(Console.ReadLine());
                        resultado = obj.Dividir(a, b);
                        Console.WriteLine("El resultado de la división es: {0}", resultado);
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.Write("Ingrese un número: ");
                        a = double.Parse(Console.ReadLine());
                        resultado = obj.RaizCuadrada(a);
                        Console.WriteLine("El resultado de la raíz cuadrada es: {0}", resultado);
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.Write("Ingrese un número: ");
                        a = double.Parse(Console.ReadLine());
                        resultado = obj.Logaritmo(a);
                        Console.WriteLine("El resultado del logaritmo es: {0}", resultado);
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.Write("Ingrese un número: ");
                        a = double.Parse(Console.ReadLine());
                        resultado = obj.Seno(a);
                        Console.WriteLine("El resultado del seno es: {0}", resultado);
                        Console.WriteLine();
                        break;

                    case 8:
                        Console.Write("Ingrese un número: ");
                        a = double.Parse(Console.ReadLine());
                        resultado = obj.Coseno(a);
                        Console.WriteLine("El resultado del coseno es: {0}", resultado);
                        Console.WriteLine();
                        break;

                    case 9:
                        Console.Write("Ingrese el numero: ");
                        a = double.Parse(Console.ReadLine());
                        resultado = obj.Tangente(a);
                        Console.WriteLine();
                        break;
                    case 10:
                        Console.WriteLine("thakns for use calculator");
                        valor = false;
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("opcion Invalida");
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
