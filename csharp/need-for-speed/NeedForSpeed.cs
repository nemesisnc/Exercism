using System;

class RemoteControlCar
{
    int speed;
    int batteryDrain;
    int distanceDriven = 0;
    int batteryStatus = 100;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return (batteryStatus < batteryDrain);
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            distanceDriven += speed;
            batteryStatus -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained() && distance >= car.DistanceDriven())
        {
            car.Drive();
        }

        return (!car.BatteryDrained() || distance <= car.DistanceDriven());
    }
}
