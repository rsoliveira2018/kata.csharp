namespace Kata.ConsoleApps.Mathematics
{
    public static class MathUtilities
    {
        public static int RecursiveFactorial(int number)
        {
            int result;
            if (number == 0 || number == 1)
                return 1;
            else
                result = number * RecursiveFactorial(number - 1);

            return result;
        }
    }
}
