using kata.console.Arrays;
using Kata.ConsoleApps.Arrays;
using Kata.ConsoleApps.Mathematics;
using System;

namespace Kata.ConsoleApps;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("|| ----------------------- Hello World! ----------------------- ||");
        Console.WriteLine("\n    This console application has the objective of serving as\n    sandbox for practices related to C# Programming.\n");
        Console.WriteLine("|| ------------------------------------------------------------ ||\n\n");

        int factorialNumber = 7;
        Console.WriteLine(
            "\tRecursive Factorial of " + factorialNumber + ": \t\t" + 
            MathUtilities.RecursiveFactorial(factorialNumber));

        int[] numbersArray = [11, 10, 30, 40, 50];
        Console.WriteLine(
            "\tRecursive Array Backwards Sum: \t\t" + 
            ArrayUtilities.SumNumbersBackwardlyRecursively(numbersArray));

        int[][] recipeRatings = [[123, 1], [234, 2], [921, 4], [123, 5]];
        Console.WriteLine(
            "\tBest Average Smallest Recipe Id: \t" +
            MatrixExercises.GetBestRecipeRatingId(recipeRatings));
    }
}
