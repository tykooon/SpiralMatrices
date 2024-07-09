using System.Runtime.CompilerServices;

namespace SpiralMatrices.Core;

public class SpiralMatrixRecursive : SpiralMatrixBase
{
    public SpiralMatrixRecursive(int rows, int cols) : base(rows, cols)
    { }

    public override int this[int i, int j]
    {
        get
        {
            CheckIndices(i, j);
            return GetElement(i, j, Rows, Cols);
        }
    }

    public override (int i, int j) GetIndices(int k)
    {
        return GetIndicesRecursive(k, Rows, Cols);
    }

    private int GetElement(int i, int j, int rows, int cols)
    {
        if (i == 1)
        {
            return j;
        }

        return cols + GetElement(cols + 1 - j, i - 1, cols, rows - 1);
    }

    public (int i, int j) GetIndicesRecursive(int k, int rows, int cols)
    {
        if(k <= cols)
        {
            return (1, k);
        }

        (int i, int j) = GetIndicesRecursive(k - cols, cols, rows - 1);
        return (j+1, cols + 1 - i);
    }
}