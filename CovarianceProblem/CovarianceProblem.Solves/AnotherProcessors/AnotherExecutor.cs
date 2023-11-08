using CovarianceProblem.Problem.Actors;
using CovarianceProblem.Problem.Processors;
using CovarianceProblem.Solves.AnotherProcessors.Factory;

namespace CovarianceProblem.Solves.AnotherProcessors;

public class AnotherExecutor
{
    private readonly AnotherProcessorFactory _factory;

    public AnotherExecutor(AnotherProcessorFactory factory) =>
        _factory = factory;

    public void Execute(params Actor[] actors)
    {
        foreach (var actor in actors)
        {
            var processor = FromFactory(actor);
            processor.Process(actor);
        }
    }

    public IActorProcessor<Actor> FromFactory<TActor>(TActor actor) where TActor : Actor =>
        _factory.Get(actor);
}