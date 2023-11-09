using BenchmarkDotNet.Running;
using CovarianceProblem.Benchmarks.Solves;

var matching = BenchmarkRunner.Run<MatchingBenchmark>();
var dynamic = BenchmarkRunner.Run<DynamicBenchmark>();
var another = BenchmarkRunner.Run<AnotherProcessorBenchmark>();