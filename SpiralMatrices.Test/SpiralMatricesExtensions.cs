using SpiralMatrices.Core;

namespace SpiralMatrices.Test;

public static class SpiralMatricesExtensions
{
    public static void PrintOut(this SpiralMatrixBase matrix)
    {
        for (var i = 1; i < matrix.Rows+1; i++)
        {
            matrix.PrintRow(i);
        }
    }

    public static void PrintRow(this SpiralMatrixBase matrix, int row)
    {
        for (var j = 1; j < matrix.Cols + 1; j++)
        {
            Console.Write("{0,5:D}", matrix[row, j]);
        }
        Console.WriteLine();
    }

    public static void PrintColumn(this SpiralMatrixBase matrix, int column)
    {
        for (var i = 1; i < matrix.Rows + 1; i++)
        {
            Console.WriteLine("{0,5:D}", matrix[i, column]);
        }
    }
}
