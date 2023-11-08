using CovarianceProblem.Problem.Actors;
using CovarianceProblem.Problem.Processors;

namespace CovarianceProblem.Problem.Factory;

public class ProcessorFactory
{
    private readonly Dictionary<Type, IActorProcessor> _processors;

    public ProcessorFactory() =>
        _processors = new Dictionary<Type, IActorProcessor>()
        {
            [typeof(Mage)] = new MageProcessor(),
            [typeof(Warrior)] = new WarriorProcessor()
        };

    public IActorProcessor<TActor> Get<TActor>() where TActor : Actor =>
        (IActorProcessor<TActor>) _processors[typeof(TActor)];
}