namespace CovarianceProblem.Problem.Actors;

public class Warrior : Actor
{
    public Warrior(int rage) =>
        Rage = rage;

    public int Rage { get; }
}