using CovarianceProblem.Problem.Actors;
using CovarianceProblem.Problem.Factory;
using CovarianceProblem.Problem.Processors;

namespace CovarianceProblem.Solves.Matching;

public class ExecutorWithMatching
{
    private readonly ProcessorFactory _factory;

    public ExecutorWithMatching(ProcessorFactory factory) =>
        _factory = factory;

    public void Execute(params Actor[] actors)
    {
        foreach (var actor in actors) 
            ProcessAfterMatch(actor);
    }

    private void ProcessAfterMatch<TActor>(TActor actor) where TActor : Actor
    {
        switch (actor)
        {
            case Mage mage: FromFactory(mage).Process(mage);
                break;
            case Warrior warrior: FromFactory(warrior).Process(warrior);
                break;
        }
    }

    private IActorProcessor<TActor> FromFactory<TActor>(TActor actor) where TActor : Actor =>
        _factory.Get<TActor>();
}