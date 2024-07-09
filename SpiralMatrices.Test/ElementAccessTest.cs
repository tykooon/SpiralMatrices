using SpiralMatrices.Core;
using Xunit;

namespace SpiralMatrices.Test;


public class ElementAccessTest
{
    static readonly int[,] matrix4x6= {
        {  1,  2,  3,  4,  5,  6 },
        { 16, 17, 18, 19, 20,  7 },
        { 15, 24, 23, 22, 21,  8 },
        { 14, 13, 12, 11, 10,  9 }
    };
    SpiralMatrixDirect matrixDirect4x6 = new(4, 6);
    SpiralMatrixRecursive matrixRecursive4x6 = new(4, 6);
    SpiralMatrixAdvanced matrixAdvanced4x6 = new(4, 6);

    SpiralMatrixDirect matrixDirectXXL = new(2000, 1800);
    SpiralMatrixRecursive matrixRecursiveXXL = new(2000, 1800);
    SpiralMatrixAdvanced matrixAdvancedXXL = new(2000, 1800);

    int Element_980_890_XXL = 3595511;


    [Fact]
    public void DirectElementAccess()
    {
        for (int i = 0; i< matrix4x6.GetLength(0); i++)
        {
            for (int j = 0; j < matrix4x6.GetLength(1); j++)
            {
                Assert.Equal(matrix4x6[i, j], matrixDirect4x6[i + 1, j + 1]);
            }
        }
    }

    [Fact]
    public void RecursiveElementAccess()
    {
        for (int i = 0; i < matrix4x6.GetLength(0); i++)
        {
            for (int j = 0; j < matrix4x6.GetLength(1); j++)
            {
                Assert.Equal(matrix4x6[i, j], matrixRecursive4x6[i + 1, j + 1]);
            }
        }
    }

    [Fact]
    public void AdvancedElementAccess()
    {
        for (int i = 0; i < matrix4x6.GetLength(0); i++)
        {
            for (int j = 0; j < matrix4x6.GetLength(1); j++)
            {
                Assert.Equal(matrix4x6[i, j], matrixAdvanced4x6[i + 1, j + 1]);
            }
        }
    }

    [Fact]
    public void DirectElementAccessXxl()
    {
        Assert.Equal(Element_980_890_XXL, matrixDirectXXL[980, 890]);
    }

    [Fact]
    public void RecursiveElementAccessXxl()
    {
        Assert.Equal(Element_980_890_XXL, matrixRecursiveXXL[980, 890]);
    }

    [Fact]
    public void AdvancedElementAccessXxl()
    {
            Assert.Equal(Element_980_890_XXL, matrixAdvancedXXL[980, 890]);
    }
}
