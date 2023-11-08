using CovarianceProblem.Problem.Actors;

namespace CovarianceProblem.Problem.Processors;

public interface IActorProcessor { }

public interface IActorProcessor<in TActor> : IActorProcessor
    where TActor : Actor
{
    void Process(TActor actor);
}