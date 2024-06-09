using System.Runtime.CompilerServices;

namespace SpiralMatrices.Core;

public class SpiralMatrixRecursive : SpiralMatrixBase
{
    public SpiralMatrixRecursive(int rows, int cols) : base(rows, cols)
    { }

    public override int this[int i, int j] => GetElement(i, j, Rows, Cols);

    public override (int i, int j) GetIndices(int k)
    {
        return (1, 1);
    }

    private int GetElement(int i, int j, int rows, int cols)
    {
        if (i == 1)
        {
            return j;
        }

        return cols + GetElement(cols + 1 - j, i - 1, cols, rows - 1);
    }
}