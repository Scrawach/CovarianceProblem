using BenchmarkDotNet.Attributes;
using CovarianceProblem.Problem.Actors;
using CovarianceProblem.Problem.Factory;
using CovarianceProblem.Solves.Dynamic;

namespace CovarianceProblem.Benchmarks.Solves;

public class DynamicBenchmark
{
    [Params(1, 10, 100)]
    public int AmountOfActors;
    
    [Params(1, 10, 100)]
    public int ExecuteIterations;
    
    private DynamicExecutor _executor;
    private Actor[] _actors;
    
    [GlobalSetup]
    public void Setup()
    {
        var factory = new ProcessorFactory();
        _executor = new DynamicExecutor(factory);
        _actors = Actors.Generate(AmountOfActors);
    }
    
    [Benchmark]
    public void Run()
    {
        for (var i = 0; i < ExecuteIterations; i++) 
            _executor.Execute(_actors);
    }
}