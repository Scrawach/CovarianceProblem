using CovarianceProblem.Problem.Actors;
using CovarianceProblem.Problem.Processors;

namespace CovarianceProblem.Solves.AnotherProcessors.Processors;

public abstract class BaseProcessor<TActor> : IActorProcessor<Actor>
    where TActor : Actor
{
    public void Process(Actor actor) =>
        Process((TActor) actor);

    protected abstract void Process(TActor actor);
}