using CovarianceProblem.Problem;
using CovarianceProblem.Problem.Actors;
using CovarianceProblem.Problem.Factory;
using FluentAssertions;

namespace CovarianceProblem.Tests.Problem;

public class ProblemTests
{
    [Test]
    public void WhenExecuteProblem_ThenShouldReturnException()
    {
        // arrange
        var actors = new Actor[] { new Mage(10), new Warrior(5) };
        var factory = new ProcessorFactory();
        var executor = new Executor(factory);

        // act
        var act = () => executor.Execute(actors);

        // assert
        act.Should().Throw<Exception>();
    }
}