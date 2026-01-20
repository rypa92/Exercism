public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int x = 0;
        for(int y = 1; y <= max; y++) {
            x += y;
        }
        return x * x;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int x = 0;
        for(int y = 1; y <= max; y++) {
            x += y * y;
        }
        return x;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}