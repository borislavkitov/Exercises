using System;

class RemoteControlCar
{
    private int Battery { get; set; }
    private int DrivenMetters { get; set; }

    public RemoteControlCar()
    {
        Battery = 100;
        DrivenMetters = 0;
    }

    public static RemoteControlCar Buy() => new();
 
    public string DistanceDisplay() => $"Driven {DrivenMetters} meters";
 
    public string BatteryDisplay() => Battery > 0 ? $"Battery at {Battery}%" : "Battery empty";

    public void Drive()
    {
        if (Battery > 0)
        {
            Battery -= 1;
            DrivenMetters += 20;
        }
    }
}
