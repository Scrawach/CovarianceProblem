using CovarianceProblem.Problem.Actors;

namespace CovarianceProblem.Solves.AnotherProcessors.Processors;

public class WarriorProcessor : BaseProcessor<Warrior>
{
    protected override void Process(Warrior actor)
    {
        // do something useful
        Console.WriteLine($"I'm warrior! Rage: {actor.Rage}");
    }
}