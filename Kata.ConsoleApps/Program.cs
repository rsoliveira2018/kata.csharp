using System;

namespace Kata.ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|| ----------------------- Hello World! ----------------------- ||");
            Console.WriteLine("\n    This console application has the objective of serving as\n    sandbox for practices related to C# Programming.\n");
            Console.WriteLine("|| ------------------------------------------------------------ ||\n\n");
            Console.WriteLine(MathUtilities.FatorialRegressivo(6));

            int[] numbers = { 11, 10, 30, 40, 50 };
            Console.WriteLine(MathUtilities.SomarArrayRegressivo(numbers));

        }
    }

    public static class MathUtilities
    {
        public static int FatorialRegressivo(int number)
        {
            int resultado;
            if (number == 0 || number == 1)
                return 1;
            else
                resultado = number * FatorialRegressivo(number - 1);

            return resultado;
        }

        public static int SomarArrayRegressivo(int[] numbers)
        {
            int indice = numbers.Length - 1;

            if (indice == 0)
                return numbers[indice];
            else
                return numbers[indice] + SomarArrayRegressivo(RemoverUltimoItemDoArray(numbers));
        }

        private static int[] RemoverUltimoItemDoArray(int[] numbers)
        {
            int[] numbersTruncado = new int[numbers.Length - 1];
            EmparelharArrays(numbers, numbersTruncado, numbersTruncado.Length - 1);
            return numbersTruncado;
        }

        private static void EmparelharArrays(int[] numbersOriginal, int[] numbersTruncado, int indice)
        {
            if (indice == 0)
            {
                numbersTruncado[indice] = numbersOriginal[indice];
                return;
            }
            else
            {
                numbersTruncado[indice] = numbersOriginal[indice];
                EmparelharArrays(numbersOriginal, numbersTruncado, indice - 1);
            }

        }
    }
}
