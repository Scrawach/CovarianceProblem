using CovarianceProblem.Problem.Actors;
using CovarianceProblem.Problem.Processors;
using MageProcessor = CovarianceProblem.Solves.AnotherProcessors.Processors.MageProcessor;
using WarriorProcessor = CovarianceProblem.Solves.AnotherProcessors.Processors.WarriorProcessor;

namespace CovarianceProblem.Solves.AnotherProcessors.Factory;

public class AnotherProcessorFactory
{
    private readonly Dictionary<Type, IActorProcessor<Actor>> _processors;

    public AnotherProcessorFactory() =>
        _processors = new Dictionary<Type, IActorProcessor<Actor>>()
        {
            [typeof(Mage)] = new MageProcessor(),
            [typeof(Warrior)] = new WarriorProcessor()
        };

    public IActorProcessor<Actor> Get<TActor>(TActor actor) where TActor : Actor =>
        _processors[actor.GetType()];
}