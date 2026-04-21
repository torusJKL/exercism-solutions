class Lasagna
{
    private const int OvenTime = 40;
    private const int LayerPrepTime = 2;
    
    public int ExpectedMinutesInOven() => OvenTime;

    public int RemainingMinutesInOven(int minsInOven){
        return ExpectedMinutesInOven() - minsInOven;
    }

    public int PreparationTimeInMinutes(int numLayers){
        return LayerPrepTime * numLayers;
    }

    public int ElapsedTimeInMinutes(int numLayers, int minsInOven){
        return PreparationTimeInMinutes(numLayers) + minsInOven;
    }
}
