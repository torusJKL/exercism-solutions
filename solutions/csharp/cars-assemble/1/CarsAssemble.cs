static class AssemblyLine
{
    const int CarsAtBaseSpeed = 221;
    
    public static double SuccessRate(int speed)
    {
        switch (speed){
            case >= 10:
                return 0.77;
                break;
            case >= 9:
                return 0.8;
                break;
            case >= 5:
                return 0.9;
                break;
            case >= 1:
                return 1;
                break;
            default:
                return 0;
                break;
        }
    }
    
    public static double ProductionRatePerHour(int speed) => CarsAtBaseSpeed * speed * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)Math.Floor(ProductionRatePerHour(speed) / 60);
}
