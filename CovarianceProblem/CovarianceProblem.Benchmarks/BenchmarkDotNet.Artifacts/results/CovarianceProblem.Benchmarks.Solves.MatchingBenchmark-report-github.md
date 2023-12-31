```

BenchmarkDotNet v0.13.10, Fedora 31 (KDE Plasma)
Intel Core i7-4770 CPU 3.40GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.304
  [Host]     : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2


```
| Method | AmountOfActors | ExecuteIterations | Mean          | Error        | StdDev       | Gen0    | Allocated |
|------- |--------------- |------------------ |--------------:|-------------:|-------------:|--------:|----------:|
| **Run**    | **1**              | **1**                 |      **10.78 μs** |     **0.213 μs** |     **0.270 μs** |  **0.0153** |      **80 B** |
| **Run**    | **1**              | **10**                |      **99.81 μs** |     **1.995 μs** |     **2.049 μs** |  **0.1221** |     **640 B** |
| **Run**    | **1**              | **100**               |   **1,074.37 μs** |    **20.759 μs** |    **24.712 μs** |       **-** |    **8002 B** |
| **Run**    | **10**             | **1**                 |     **101.59 μs** |     **1.811 μs** |     **1.694 μs** |  **0.1221** |     **688 B** |
| **Run**    | **10**             | **10**                |   **1,031.27 μs** |    **20.613 μs** |    **35.557 μs** |       **-** |    **7202 B** |
| **Run**    | **10**             | **100**               |  **10,594.85 μs** |   **209.556 μs** |   **241.325 μs** | **15.6250** |   **75215 B** |
| **Run**    | **100**            | **1**                 |   **1,031.25 μs** |    **20.203 μs** |    **19.842 μs** |       **-** |    **7234 B** |
| **Run**    | **100**            | **10**                |  **10,198.08 μs** |   **184.930 μs** |   **259.246 μs** | **15.6250** |   **70585 B** |
| **Run**    | **100**            | **100**               | **102,853.83 μs** | **2,001.644 μs** | **2,531.439 μs** |       **-** |  **724987 B** |
