using CovarianceProblem.Problem.Actors;
using CovarianceProblem.Solves.AnotherProcessors;
using CovarianceProblem.Solves.AnotherProcessors.Factory;
using FluentAssertions;

namespace CovarianceProblem.Tests.Solves;

public class AnotherExecutorTests
{
    [Test]
    public void WhenExecuteProblem_ThenShouldWork_WithoutThrowException()
    {
        // arrange
        var actors = new Actor[] { new Mage(10), new Warrior(5) };
        var factory = new AnotherProcessorFactory();
        var executor = new AnotherExecutor(factory);
        
        // act
        var act = () => executor.Execute(actors);
        
        // assert
        act.Should().NotThrow();
    }
}