using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            #region Ejemplo 3x+1
            Console.WriteLine("= 3X+1 =");
            Console.Write("Ingresa un numero: ");
            num = int.Parse(Console.ReadLine());
            int conRE = 0;
            int contIT = FormulaLocaIterativa(num);
            FormulaLocaRecursiva(num, ref conRE);
            Console.WriteLine($"Tomo {conRE} intentos para que {num} fuera 1.");
            #endregion

            #region Ejemplo factorial
            Console.Write("Ingresa un numero: ");
            num = int.Parse(Console.ReadLine());
            int factIT = FactorialIterativa(num);
            int factRE = FactorialRecursiva(num);
            Console.WriteLine($"el factorial de {num} es: " + factIT);
            #endregion

            #region Ejemplo sumatoria
            Console.WriteLine("= sumatoria de un numero ( S = n (n + 1) / 2) =");
            Console.Write("Ingresa un numero: ");
            num = int.Parse(Console.ReadLine());
            int sumRE = SumatoriaRecursiva(num);
            int sumIT = SumatoriaIterativa(num);
            Console.WriteLine($"tu sumatoria de {num} es: " + sumIT);
            #endregion

            Console.ReadKey();
        }


        #region Ejemplo Sumatoria
        //Recursiva
        private static int SumatoriaRecursiva(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return (num * (num + 1)) / 2 + SumatoriaRecursiva(num - 1);
            }
        }

        //Iterativo
        private static int SumatoriaIterativa(int num)
        {
            int resultado = 0;
            for (int i = 1; i < num + 1; i++)
            {
                resultado += (i * (i + 1) / 2);
            }
            return resultado;
        }
        #endregion

        #region Ejemplo factorial
        //recursivo
        private static int FactorialRecursiva(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * FactorialRecursiva(num - 1);
            }
        }

        //Iterativo
        private static int FactorialIterativa(int num)
        {
            int resultado = 1;
            for (int i = 1; i <= num; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
        #endregion

        #region Ejemplo 3x+1
        //recursivo
        private static int FormulaLocaRecursiva(int num, ref int contador)
        {
            if (num == 1)
            {
                return 1;
            }
            else if (num % 2 == 0)
            {
                contador++;
                return FormulaLocaRecursiva(num / 2, ref contador);
            }
            else
            {
                contador++;
                return FormulaLocaRecursiva(3 * num + 1, ref contador);
            }
        }

        //Iterativo
        private static int FormulaLocaIterativa(int num)
        {
            int contador = 0;
            while (num != 1)
            {
                contador++;
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = (3 * num) + 1;
                }
            }
            return contador;
        }
        #endregion
    }
}
