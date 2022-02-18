using System;

static class AssemblyLine
{

    private const double HundredPercent = 1;
    private const double NintyPercent = 0.9;
    private const double EightyPercent = 0.8;
    private const double SeventySevenPercent = 0.77;
    private const double ZeroPercent = 0;
    private const double ProdPerHour = 221.00;

    public static double SuccessRate(int speed) => speed switch
    {
        >= 1 and < 5 => HundredPercent,
        >= 5 and <=8 => NintyPercent,
        9 => EightyPercent,
        10 => SeventySevenPercent,
        _ => ZeroPercent,
    };

    public static double ProductionRatePerHour(int speed) => (speed * ProdPerHour) * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
}
