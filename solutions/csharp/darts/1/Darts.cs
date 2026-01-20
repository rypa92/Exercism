public static class Darts
{
    public static double SquareRoot(double input) {
        double x = input;
        double y = 1;
        double tol = 0.000000000001;
        while (x - y > tol)
        {
            x = (x + y) / 2;
            y = input / x;
        }
        return x;
    }
    
    public static int Score(double x, double y) {
        double x1 = x;
        double y1 = y;
        double x2 = 0.0;
        double y2 = 0.0;

        double xSide = x2-x1;
        double ySide = y2-y1;

        decimal tempScore = (decimal)SquareRoot((xSide*xSide)+(ySide*ySide));

        Console.WriteLine(tempScore);
        if(tempScore > 10) {
            return 0;
        } else if ( tempScore <= 10 && tempScore > 5 ) {
            return 1;
        } else if ( tempScore <= 5 && tempScore > 1 ) {
            return 5;
        } else if ( tempScore <= 1 ) {
            return 10;
        } else {
            return 0;
        }
    }
}