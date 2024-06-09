namespace SpiralMatrices.Core;

public class SpiralMatrixAdvanced : SpiralMatrixBase
{
    public SpiralMatrixAdvanced(int rows, int cols) : base(rows, cols)
    { }

    public override int this[int i, int j]
    {
        get
        {
            var iReverse = Rows + 1 - i;
            var jReverse = Cols + 1 - j;
            var layer = i < j
                ? (iReverse < jReverse ? (i < iReverse ? i : iReverse) : (i < jReverse ? i : jReverse))
                : (iReverse < jReverse ? (j < iReverse ? j : iReverse) : (j < jReverse ? j : jReverse));

            var numberOffset = 2 * (layer - 1) * (Rows + Cols) - 4 * (layer - 1) * (layer - 1);

            if (layer == i)
            {
                return numberOffset + j + 1 - layer;
            }
            if (layer == jReverse)
            {
                return numberOffset + Cols + 2 - 2 * layer + i - layer;
            }
            if (layer == iReverse)
            {
                return numberOffset + Cols + 2 - 2 * layer + Rows + 1 - 2 * layer + Cols + 1 - layer - j;
            }
            if (layer == j)
            {
                return numberOffset + Cols + 2 - 2 * layer + Rows + 1 - 2 * layer + Cols + 1 - 2 * layer + Rows + 1 - layer - i;
            }

            throw new Exception("Layer Error");
        }
    }


    public override (int i, int j) GetIndices(int k)
    {
        return (1, 1);
    }
}