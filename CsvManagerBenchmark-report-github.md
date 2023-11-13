```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22631.2506/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-11800H 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100-rc.2.23502.2
  [Host]     : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2


```
| Method                      | Mean     | Error   | StdDev   |
|---------------------------- |---------:|--------:|---------:|
| SimpleTransformCsvBenchmark | 298.1 ns | 5.92 ns |  9.05 ns |
| TransformCsv                | 453.1 ns | 8.85 ns | 10.19 ns |
