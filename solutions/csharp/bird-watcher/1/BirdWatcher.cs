class BirdCount
{
    private int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
        return birdsPerDay[6];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[6]++;
    }

    public bool HasDayWithoutBirds()
    {
        for(int x = 0; x < birdsPerDay.Length; x++) {
            if(birdsPerDay[x] == 0) {
                return true;
            } else {
                continue;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for(int x = 0; x < numberOfDays; x++) {
            count += birdsPerDay[x];
        }
        return count;
    }

    public int BusyDays()
    {
        int count = 0;
        for(int x = 0; x < birdsPerDay.Length; x++) {
            if(birdsPerDay[x] >= 5) {
                count++;
            }
        }
        return count;
    }
}
