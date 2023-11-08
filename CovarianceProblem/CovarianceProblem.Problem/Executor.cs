using CovarianceProblem.Problem.Actors;
using CovarianceProblem.Problem.Factory;
using CovarianceProblem.Problem.Processors;

namespace CovarianceProblem.Problem;

public class Executor
{
    private readonly ProcessorFactory _factory;

    public Executor(ProcessorFactory factory) =>
        _factory = factory;

    public void Execute(params Actor[] actors)
    {
        foreach (var actor in actors)
        {
            var processor = FromFactory(actor);
            processor.Process(actor);
        }
    }

    private IActorProcessor<TActor> FromFactory<TActor>(TActor actor) where TActor : Actor =>
        _factory.Get<TActor>();
}