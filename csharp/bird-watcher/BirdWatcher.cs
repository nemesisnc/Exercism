using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;
        return;
    }

    public bool HasDayWithoutBirds()
    {
        for (int i = 0;i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] == 0)
            {
                return true;
            }
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int birdCounter = 0;
        for (int i = 0;i < numberOfDays; i++)
        {
            birdCounter += birdsPerDay[i];
        }

        return birdCounter;
    }

    public int BusyDays()
    {
        int busyDayCounter = 0;
        for (int i = 0;i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] >= 5)
            {
                busyDayCounter++;
            }
        }

        return busyDayCounter;
    }
}
