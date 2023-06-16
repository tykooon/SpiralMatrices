namespace SpiralGreedy;

public class SpiralMatrixG : SpiralBase.SpiralMatrixBase
{
    public SpiralMatrixG(int rows, int columns) : base(rows, columns) { }

    public override int this[int i, int j]
    {
        get
        {
            CheckIndices(i, j);
            throw new NotImplementedException();
        }
    }

    public override (int i, int j) GetIndices(int k)
    {
        throw new NotImplementedException();
    }
}