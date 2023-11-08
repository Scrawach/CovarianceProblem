using CovarianceProblem.Problem.Actors;

namespace CovarianceProblem.Problem.Processors;

public class MageProcessor : IActorProcessor<Mage>
{
    public void Process(Mage actor)
    {
        // do something useful
        Console.WriteLine($"I'm mage! With {actor.Mana} mana points.");
    }
}