using System;
class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed;
    private int batteryDrain;
    private int distance = 0;
    private int battery = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }
    public bool BatteryDrained()
    {
       if (this.battery < batteryDrain) {
           return true;
       } else {
       return false;
       }
    }
    public int DistanceDriven()
    {
        return this.distance;
    }
    public void Drive()
    {
        if (this.BatteryDrained() == false) {
            this.distance += this.speed;
            this.battery -= this.batteryDrain;
        }
    }
    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}
class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;

    public RaceTrack(int _distance)
    {
        this.distance = _distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.BatteryDrained() == false) {
            car.Drive();
            if (car.DistanceDriven() >= this.distance) {
                return true;
            }
        }
        return false;
    }
}
