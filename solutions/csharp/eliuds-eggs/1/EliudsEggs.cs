public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        int eggSlot = 0;
        int totalEggs = 0;
        while (encodedCount > 0) {
            eggSlot = encodedCount % 2;
            if(eggSlot == 1) {
                totalEggs++;
            }
            encodedCount /= 2;
        }
        return totalEggs;
    }
}