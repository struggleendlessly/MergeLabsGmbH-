using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using MergeLabsGmbH;

var summary = BenchmarkRunner.Run<CsvManagerBenchmark>();

Console.WriteLine("Hello, World!");

public class CsvManagerBenchmark
{
    private const string CsvData = "header,header\nANNUL,ANNULLED\nnull,NILL\nNULL,NULL";

    [Benchmark]
    public void SimpleTransformCsvBenchmark()
    {
        CsvManager.SimpleTransformCsv(CsvData);
    }

    [Benchmark]
    public void TransformCsv()
    {
        CsvManager.TransformCsv(CsvData);
    }
}