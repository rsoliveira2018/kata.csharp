namespace kata.console.Arrays;

public static class MatrixExercises
{
    /* 
     * This method expects a matrix array containing two integers representing the recipe ID and the recipe rating, e.g.:
     * int[][] ratings = [[123, 1], [234, 2], [921, 4], [123, 5]];
     * where we are able to see the recipe IDs 123, 234 and 921 and the ratings 1, 2, 4, and 5.
     * 
     * The returned value is the recipe ID of the highest average rating recipe.
    */
    public static int GetBestRecipeRatingId(int[][] recipeRatings)
    {
        int[,] ratingsAverages = new int[recipeRatings.Length, 2];

        for (int i = 0; i < recipeRatings.Length; i++)
        {
            var recipeId = recipeRatings[i][0];
            var recipeAvg = 0;
            var counter = 0;

            for (int j = 0; j < recipeRatings.Length; j++)
            {
                if (recipeId == recipeRatings[j][0])
                {
                    recipeAvg += recipeRatings[j][1];
                    counter++;
                }
            }

            recipeAvg /= counter;

            ratingsAverages[i, 0] = recipeId;
            ratingsAverages[i, 1] = recipeAvg;
        }

        var highestAverage = int.MinValue;
        var bestRecipeId = int.MaxValue;
        for (int i = 0; i < ratingsAverages.Length / 2; i++)
        {
            if (ratingsAverages[i, 1] > highestAverage)
            {
                highestAverage = ratingsAverages[i, 1];
                bestRecipeId = ratingsAverages[i, 0];
            }
            else if (ratingsAverages[i, 1] == highestAverage)
            {
                if (ratingsAverages[i, 0] < bestRecipeId)
                {
                    bestRecipeId = ratingsAverages[i, 0];
                }
            }
        }

        return bestRecipeId;
    }


}
