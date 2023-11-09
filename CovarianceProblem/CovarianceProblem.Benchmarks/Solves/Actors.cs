using CovarianceProblem.Problem.Actors;

namespace CovarianceProblem.Benchmarks.Solves;

public static class Actors
{
    public static Actor[] Generate(int amountOfActors)
    {
        var random = new Random();
        var actors = new Actor[amountOfActors];
        
        for (var i = 0; i < amountOfActors; i++)
        {
            var value = random.Next(0, 2);
            actors[i] = value == 0 ? new Mage(0) : new Warrior(0);
        }

        return actors;
    }
}