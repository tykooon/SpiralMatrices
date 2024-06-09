namespace SpiralMatrices.Core;

public class SpiralMatrixDirect : SpiralMatrixBase
{
    public SpiralMatrixDirect(int rows, int cols) : base(rows, cols)
    { }

    public override int this[int i, int j]
    {
        get
        {
            var iCount = 1;
            var jCount = 1;
            var number = 1;

            (int i, int j) delta = (0, 1);
            (int min, int max) rangeI = (1, Rows);
            (int min, int max) rangeJ = (1, Cols);

            while ((iCount, jCount) != (i, j))
            {
                if (!isInRange((iCount + delta.i, jCount + delta.j), rangeI, rangeJ))
                {
                    switch (delta)
                    {
                        case (0, 1):
                            rangeI.min++;
                            break;
                        case (1, 0):
                            rangeJ.max--;
                            break;
                        case (0, -1):
                            rangeI.max--;
                            break;
                        case (-1, 0):
                            rangeJ.min++;
                            break;
                    }
                    delta = (delta.j, -delta.i);
                }
                iCount += delta.i;
                jCount += delta.j;
                number++;
            }

            return number;
        }
    }


    public override (int i, int j) GetIndices(int k)
    {
        return (1, 1);
    }

    protected bool isInRange((int i, int j) delta, (int min, int max) rangeI, (int min, int max) rangeJ)
    {
        return delta.i >= rangeI.min
            && delta.i <= rangeI.max
            && delta.j >= rangeJ.min
            && delta.j <= rangeJ.max;
    }

}