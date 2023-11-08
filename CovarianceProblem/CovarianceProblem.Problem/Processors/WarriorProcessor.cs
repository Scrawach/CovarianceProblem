using CovarianceProblem.Problem.Actors;

namespace CovarianceProblem.Problem.Processors;

public class WarriorProcessor : IActorProcessor<Warrior>
{
    public void Process(Warrior actor)
    {
        // do something useful
        Console.WriteLine($"I'm warrior! Rage: {actor.Rage}");
    }
}