using BenchmarkDotNet.Attributes;
using SpiralMatrices.Core;

namespace SpiralMatrices.Test;

//[MemoryDiagnoser]
[ShortRunJob]
public class ElementAccessBenchmark
{
    [Params(100, 1000, 7000, 45000)]
    public int matrixSize;

    SpiralMatrixDirect? matrixDirect;
    SpiralMatrixRecursive? matrixRecursive;
    SpiralMatrixAdvanced? matrixAdvanced;

    [GlobalSetup]
    public void Setup()
    {
        matrixDirect = new(matrixSize, matrixSize);
        matrixRecursive = new(matrixSize, matrixSize);
        matrixAdvanced = new(matrixSize, matrixSize);
    }

    [Benchmark]
    public void ElementAccessDirect()
    {
        _ = matrixDirect![matrixSize / 2, matrixSize / 2];
    }

    [Benchmark]
    public void ElementAccessRecursive()
    {
        _ = matrixRecursive![matrixSize / 2, matrixSize / 2];
    }

    [Benchmark]
    public void ElementAccessAdvanced()
    {
        _ = matrixAdvanced![matrixSize / 2, matrixSize / 2];
    }
}