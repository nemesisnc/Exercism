using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0) { return 0.00; } 
        else if (speed >= 1 && speed <= 4) { return 1.00; } 
        else if (speed >= 5 && speed <= 8) { return 0.90; } 
        else if (speed == 9) { return 0.80; } 
        else if (speed == 10) { return 0.77; } 
        else throw new NotImplementedException();
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return SuccessRate(speed) * 221 * speed;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)(ProductionRatePerHour(speed) / 60);
    }
}
