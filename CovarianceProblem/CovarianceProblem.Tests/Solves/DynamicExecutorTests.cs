using CovarianceProblem.Problem.Actors;
using CovarianceProblem.Problem.Factory;
using CovarianceProblem.Solves.Dynamic;
using FluentAssertions;

namespace CovarianceProblem.Tests.Solves;

public class DynamicExecutorTests
{
    [Test]
    public void WhenExecuteProblem_ThenShouldWork_WithoutThrowException()
    {
        // arrange
        var actors = new Actor[] { new Mage(10), new Warrior(5) };
        var factory = new ProcessorFactory();
        var dynamicExecutor = new DynamicExecutor(factory);
        
        // act
        var act = () => dynamicExecutor.Execute(actors);
        
        // assert
        act.Should().NotThrow();
    }
}