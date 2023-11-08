using CovarianceProblem.Problem.Actors;
using CovarianceProblem.Problem.Factory;
using CovarianceProblem.Solves.Matching;
using FluentAssertions;

namespace CovarianceProblem.Tests.Solves;

public class MatchingExecutorTests
{
    [Test]
    public void WhenExecuteProblem_ThenShouldWork_WithoutThrowException()
    {
        // arrange
        var actors = new Actor[] { new Mage(10), new Warrior(5) };
        var factory = new ProcessorFactory();
        var dynamicExecutor = new ExecutorWithMatching(factory);
        
        // act
        var act = () => dynamicExecutor.Execute(actors);
        
        // assert
        act.Should().NotThrow();
    }
}