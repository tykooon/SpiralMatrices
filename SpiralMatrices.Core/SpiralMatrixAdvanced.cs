namespace SpiralMatrices.Core;

public class SpiralMatrixAdvanced : SpiralMatrixBase
{
    public SpiralMatrixAdvanced(int rows, int cols) : base(rows, cols)
    { }

    public override int this[int i, int j]
    {
        get
        {
            CheckIndices(i, j);
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
        double rows = Rows;
        double cols = Cols;
        var layer = (int) Math.Ceiling((cols + rows - Math.Sqrt((cols + rows)*(cols + rows) - 4*k))/4.0);
        var numberOffset = 2 * (layer - 1) * (Rows + Cols) - 4 * (layer - 1) * (layer - 1);
        var biasedValue = k - numberOffset;
        //Console.WriteLine("biased: " + biasedValue);
        //Console.WriteLine($"Limits: {Cols + 2 - 2 * layer} | {Cols + 2 - 2 * layer + Rows + 1 - 2 * layer} | {Cols + 2 - 2 * layer + Rows + 1 - 2 * layer + Cols + 1 - 2 * layer} | {2 * (Cols + Rows) - 4 * (2 * layer - 1)} ");
        if (biasedValue <= Cols +2 - 2*layer)
        {
            return (layer, biasedValue + layer - 1);
        }

        if (biasedValue <= Cols + 2 - 2 * layer + Rows + 1 - 2 * layer)
        {
            return (biasedValue - (Cols + 2 - 2 * layer) + layer, Cols + 1 - layer);
        }

        if (biasedValue <= Cols + 2 - 2 * layer + Rows + 1 - 2 * layer + Cols + 1 - 2 * layer)
        {
            return (Rows + 1 - layer, Cols - biasedValue + (Cols + 2 - 2 * layer + Rows + 1 - 2 * layer) + 1 - layer );
        }

        if (biasedValue <= 2 * (Cols + Rows) - 4 * (2 * layer - 1))
        {
            return (Rows - biasedValue + (Cols + 2 - 2 * layer + Rows + 1 - 2 * layer + Cols + 1 - 2 * layer) - layer + 1, layer);
        }

        throw new Exception("Layer Error");
    }
}