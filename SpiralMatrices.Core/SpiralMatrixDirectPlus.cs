namespace SpiralMatrices.Core;

public class SpiralMatrixDirectPlus : SpiralMatrixBase
{
    public SpiralMatrixDirectPlus(int rows, int cols) : base(rows, cols)
    { }

    public override int this[int i, int j]
    {
        get
        {
            return 1;
        }
    }


    public override (int i, int j) GetIndices(int k)
    {
        return (1, 1);
    }
}