namespace SpiralMatrices.Core;

public class SpiralMatrixAdvanvced : SpiralMatrixBase
{
    public SpiralMatrixAdvanvced(int rows, int cols) : base(rows, cols)
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