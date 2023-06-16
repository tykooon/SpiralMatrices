namespace SpiralBase;

public abstract class SpiralMatrixBase
{
    private readonly int _rows;
    private readonly int _cols;

    public int Rows => _rows;
    public int Cols => _cols;
    public int MaxElement => _rows * _cols;

    public abstract int this[int i, int j] { get; }
    public abstract (int i, int j) GetIndices(int k);

    public SpiralMatrixBase(int rows, int cols)
    {
        _rows = rows;
        _cols = cols;
    }

    protected void CheckIndices(int i, int j)
    {
        if (i < 0 || j < 0 || i >= _rows || j >= _cols)
        {
            throw new ArgumentOutOfRangeException("wrong indices");
        }
    }
}