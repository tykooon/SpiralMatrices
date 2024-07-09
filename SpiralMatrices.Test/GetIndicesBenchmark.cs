using BenchmarkDotNet.Attributes;
using SpiralMatrices.Core;

namespace SpiralMatrices.Test;

//[MemoryDiagnoser]
[ShortRunJob]
public class GetIndicesBenchmark
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
    public void GetIndicesDirect()
    {
        _ = matrixDirect!.GetIndices(matrixSize * matrixSize - 5);
    }

    [Benchmark]
    public void GetIndicesRecursive()
    {
        _ = matrixRecursive!.GetIndices(matrixSize * matrixSize - 5);
    }

    [Benchmark]
    public void GetIndicesAdvanced()
    {
        _ = matrixAdvanced!.GetIndices(matrixSize * matrixSize - 5);
    }
}

