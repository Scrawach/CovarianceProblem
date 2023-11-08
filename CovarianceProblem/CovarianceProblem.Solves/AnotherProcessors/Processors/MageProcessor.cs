using CovarianceProblem.Problem.Actors;

namespace CovarianceProblem.Solves.AnotherProcessors.Processors;

public class MageProcessor : BaseProcessor<Mage>
{
    protected override void Process(Mage actor)
    {
        // do something useful
        Console.WriteLine($"I'm mage! With {actor.Mana} mana points.");
    }
}