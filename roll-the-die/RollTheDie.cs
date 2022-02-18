using System;

public class Player
{
    static readonly Random dice = new();

    public int RollDie() => dice.Next(1, 18);

    public double GenerateSpellStrength() => dice.NextDouble() * 100.00;
}
