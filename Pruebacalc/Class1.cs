using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcucientific
{
    public class Class1
    {
        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        public  double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        public  double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }
            return num1 / num2;
        }
        public  double RaizCuadrada(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo");
            }

            return Math.Sqrt(a);
        }

        public  double Logaritmo(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("No se puede calcular el logaritmo de un número negativo");
            }

            return Math.Log10(a);
        }

        public  double Seno(double a)
        {
            return Math.Sin(a);
        }

        public double Coseno(double a)
        {
            return Math.Cos(a);
        }

        public  double Tangente(double a)
        {
            return Math.Tan(a);
        }
    }
 }
