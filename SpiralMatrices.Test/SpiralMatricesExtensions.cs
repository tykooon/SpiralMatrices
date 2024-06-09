using SpiralMatrices.Core;

namespace SpiralMatrices.Test;

public static class SpiralMatricesExtensions
{
    public static void PrintOut(this SpiralMatrixBase matrix)
    {
        for (var i = 1; i < matrix.Rows+1; i++)
        {
            for(var j = 1; j < matrix.Cols+1; j++)
            {
                Console.Write("{0,5:D}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
