using CovarianceProblem.Problem.Actors;
using CovarianceProblem.Problem.Factory;
using CovarianceProblem.Problem.Processors;

namespace CovarianceProblem.Solves.Dynamic;

public class DynamicExecutor
{
    private readonly ProcessorFactory _factory;

    public DynamicExecutor(ProcessorFactory factory) =>
        _factory = factory;

    public void Execute(params Actor[] actors)
    {
        foreach (var actor in actors) 
            Process((dynamic)actor);
    }

    private void Process<TActor>(TActor actor) where TActor : Actor
    {
        var processor = FromFactory(actor);
        processor.Process(actor);
    }
    
    private IActorProcessor<TActor> FromFactory<TActor>(TActor actor) where TActor : Actor =>
        _factory.Get<TActor>();
}