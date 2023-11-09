using BenchmarkDotNet.Attributes;
using CovarianceProblem.Problem.Actors;
using CovarianceProblem.Solves.AnotherProcessors;
using CovarianceProblem.Solves.AnotherProcessors.Factory;

namespace CovarianceProblem.Benchmarks.Solves;

public class AnotherProcessorBenchmark
{
    [Params(1, 10, 100)]
    public int AmountOfActors;
    
    [Params(1, 10, 100)]
    public int ExecuteIterations;
    
    private AnotherExecutor _executor;
    private Actor[] _actors;
    
    [GlobalSetup]
    public void Setup()
    {
        var factory = new AnotherProcessorFactory();
        _executor = new AnotherExecutor(factory);
        _actors = Actors.Generate(AmountOfActors);
    }
    
    [Benchmark]
    public void Run()
    {
        for (var i = 0; i < ExecuteIterations; i++) 
            _executor.Execute(_actors);
    }
}