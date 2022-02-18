using System;

public static class Leap
{
    private static bool IsDivisible(int number, int divisor) => number % divisor == 0;
    public static bool IsLeapYear(int year) => IsDivisible(year, 4) && !IsDivisible(year, 100) || IsDivisible(year, 400);
}