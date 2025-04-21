namespace Kata.ConsoleApps.Arrays;

public static class ArrayUtilities
{
    public static int SumNumbersBackwardlyRecursively(int[] numbers)
    {
        int lastNumberIndex = numbers.Length - 1;

        if (lastNumberIndex == 0)
            return numbers[lastNumberIndex];
        else
            return numbers[lastNumberIndex] + SumNumbersBackwardlyRecursively(RemoveLastNumberInArray(numbers));
    }

    private static int[] RemoveLastNumberInArray(int[] numbers)
    {
        int[] truncatedNumbers = new int[numbers.Length - 1];
        CopyArrayRecursively(numbers, truncatedNumbers, truncatedNumbers.Length - 1);
        return truncatedNumbers;
    }

    private static void CopyArrayRecursively(int[] sourceNumbers, int[] truncatedNumbers, int truncateIndex)
    {
        truncatedNumbers[truncateIndex] = sourceNumbers[truncateIndex];
        if (truncateIndex != 0)
            CopyArrayRecursively(sourceNumbers, truncatedNumbers, truncateIndex - 1);

    }
}
