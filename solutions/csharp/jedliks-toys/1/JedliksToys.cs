class RemoteControlCar
{
    private int _batteryPercentage = 100;
    private int _metersDriven;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_metersDriven} meters";

    public string BatteryDisplay()
    {
        if (IsBatteryEmpty()){
            return "Battery empty";
        }

        return $"Battery at {_batteryPercentage}%";
    }

    public void Drive()
    {
        if (IsBatteryEmpty())
            return;

        _batteryPercentage -= 1;
        _metersDriven += 20;
    }

    private bool IsBatteryEmpty() => _batteryPercentage <= 0;
}
