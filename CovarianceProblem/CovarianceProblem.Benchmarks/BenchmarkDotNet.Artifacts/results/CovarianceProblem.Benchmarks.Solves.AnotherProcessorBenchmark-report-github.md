```

BenchmarkDotNet v0.13.10, Fedora 31 (KDE Plasma)
Intel Core i7-4770 CPU 3.40GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.304
  [Host]     : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2


```
| Method | AmountOfActors | ExecuteIterations | Mean          | Error        | StdDev       | Gen0    | Allocated |
|------- |--------------- |------------------ |--------------:|-------------:|-------------:|--------:|----------:|
| **Run**    | **1**              | **1**                 |      **10.69 μs** |     **0.212 μs** |     **0.268 μs** |  **0.0153** |      **80 B** |
| **Run**    | **1**              | **10**                |      **99.22 μs** |     **1.969 μs** |     **2.022 μs** |  **0.1221** |     **640 B** |
| **Run**    | **1**              | **100**               |   **1,082.10 μs** |    **21.580 μs** |    **30.950 μs** |       **-** |    **8002 B** |
| **Run**    | **10**             | **1**                 |     **103.48 μs** |     **1.498 μs** |     **1.401 μs** |  **0.1221** |     **704 B** |
| **Run**    | **10**             | **10**                |   **1,013.20 μs** |    **19.524 μs** |    **28.001 μs** |       **-** |    **7042 B** |
| **Run**    | **10**             | **100**               |  **10,171.44 μs** |   **197.506 μs** |   **249.782 μs** | **15.6250** |   **67215 B** |
| **Run**    | **100**            | **1**                 |   **1,023.40 μs** |    **20.180 μs** |    **17.889 μs** |       **-** |    **7154 B** |
| **Run**    | **100**            | **10**                |  **10,349.87 μs** |   **206.968 μs** |   **230.044 μs** | **15.6250** |   **71535 B** |
| **Run**    | **100**            | **100**               | **103,667.45 μs** | **2,033.049 μs** | **2,850.050 μs** |       **-** |  **717122 B** |
