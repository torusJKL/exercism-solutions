class BirdCount
{
    private int[] _birdsPerDay;
    private static int[] _lastWeeksBirdCount = new int[] {0, 2, 5, 3, 7, 8, 4};

    public BirdCount(int[] _birdsPerDay)
    {
        this._birdsPerDay = _birdsPerDay;
    }

    public static int[] LastWeek() => _lastWeeksBirdCount;

    public int Today() => _birdsPerDay[_birdsPerDay.Length - 1];

    public void IncrementTodaysCount() => ++_birdsPerDay[_birdsPerDay.Length - 1];

    public bool HasDayWithoutBirds()
    {
        for (int i = 0; i < _birdsPerDay.Length; ++i){
            if (_birdsPerDay[i] <= 0)
                return true;
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for (int i = 0; i < numberOfDays; ++i){
            sum += _birdsPerDay[i];
        }

        return sum;
    }

    public int BusyDays()
    {
        int busyDays = 0;

        for (int i = 0; i < _birdsPerDay.Length; ++i){
            if (_birdsPerDay[i] >= 5)
                ++busyDays;
        }

        return busyDays;
    }
}
