class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int remainingMinutes) => 40 - remainingMinutes;

    public int PreparationTimeInMinutes(int layerCount) => layerCount * 2;

    public int ElapsedTimeInMinutes(int layerCount, int minutesInOven) => layerCount * 2 + minutesInOven;
}
