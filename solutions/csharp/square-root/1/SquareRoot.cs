public static class SquareRoot
{
    public static int Root(int number)
    {
        int result = 0;
        int a = 1;
        int d = 3;
        while (a <= number)
        {
            a = a + d;
            d = d + 2;
            result = result + 1;
        }
        return result;
    }
}
