namespace CovarianceProblem.Problem.Actors;

public class Mage : Actor
{
    public Mage(int mana) =>
        Mana = mana;

    public int Mana { get; }
}