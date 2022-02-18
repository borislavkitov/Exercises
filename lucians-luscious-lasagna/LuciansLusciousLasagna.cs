class Lasagna
{
    private const int MinutesForLasagnaMakeInOven = 40;
    private const int MinutesForLayerMaking = 2;

    public int ExpectedMinutesInOven() => MinutesForLasagnaMakeInOven;
 
    public int RemainingMinutesInOven(int minutesInOven) => MinutesForLasagnaMakeInOven - minutesInOven;

    public int PreparationTimeInMinutes(int layers) => layers * MinutesForLayerMaking;
 
    public int ElapsedTimeInMinutes(int layers,int minutesInOven) => PreparationTimeInMinutes(layers) + minutesInOven;
  
}
