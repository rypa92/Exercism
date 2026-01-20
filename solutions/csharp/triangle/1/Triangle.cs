public static class Triangle
{
    public static bool triangleCheck(double side1, double side2, double side3)
    {
        int x = 0;
        if (side1 + side2 >= side3) {
            x+=1;
        }
        if (side2 + side3 >= side1) {
            x+=1;
        }
        if (side1 + side3 >= side2) {
            x+=1;
        }
        if (x == 3) {
            return true;
        } else {
            return false;
        }
    }
    
    public static bool IsScalene(double side1, double side2, double side3)
    {
        if (side1 + side2 + side3 > 0) {
            if (IsIsosceles(side1, side2, side3)) {
                return false;
            } else if (IsEquilateral(side1, side2, side3)) {
                return false;
            } else {
                return triangleCheck(side1, side2, side3);
            }
        } else {
            return false;
        }
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if (side1 + side2 + side3 > 0) {
            if (side1 == side2 || side1 == side3 || side2 == side3) {
                return triangleCheck(side1, side2, side3);
            } else {
                return false;
            }
        } else {
            return false;
        }
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        if (side1 + side2 + side3 > 0) {
            if (side1 == side2 && side2 == side3) {
                return triangleCheck(side1, side2, side3);;
            } else {
                return false;
            }
        } else {
            return false;
        }
    }
}