using Kata.ConsoleApps.Arrays;
using Kata.ConsoleApps.Mathematics;
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

            
            Console.WriteLine(
                "\tRecursive Factorial of 6: \t\t" + 
                MathUtilities.RecursiveFactorial(6));

            int[] numbers = { 11, 10, 30, 40, 50 };
            Console.WriteLine(
                "\tRecursive Array Backwards Sum: \t\t" + 
                ArrayUtilities.SumNumbersBackwardlyRecursively(numbers));

        }
    }
}
