using SpiralMatrices.Core;
using Xunit;

namespace SpiralMatrices.Test;


public class GetIndicesTest
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
    public void DirectGetIndices()
    {
        for (int i = 0; i < matrix4x6.GetLength(0); i++)
        {
            for (int j = 0; j < matrix4x6.GetLength(1); j++)
            {
                Assert.Equal(i + 1, matrixDirect4x6.GetIndices(matrix4x6[i, j]).i);
                Assert.Equal(j + 1, matrixDirect4x6.GetIndices(matrix4x6[i, j]).j);
            }
        }
    }

    [Fact]
    public void RecursiveGetIndices()
    {
        for (int i = 0; i < matrix4x6.GetLength(0); i++)
        {
            for (int j = 0; j < matrix4x6.GetLength(1); j++)
            {
                Assert.Equal(i + 1, matrixRecursive4x6.GetIndices(matrix4x6[i, j]).i);
                Assert.Equal(j + 1, matrixRecursive4x6.GetIndices(matrix4x6[i, j]).j);
            }
        }
    }

    [Fact]
    public void AdvancedGetIndices()
    {
        for (int i = 0; i < matrix4x6.GetLength(0); i++)
        {
            for (int j = 0; j < matrix4x6.GetLength(1); j++)
            {
                Assert.Equal(i + 1, matrixAdvanced4x6.GetIndices(matrix4x6[i, j]).i);
                Assert.Equal(j + 1, matrixAdvanced4x6.GetIndices(matrix4x6[i, j]).j);
            }
        }
    }

    [Fact]
    public void DirectElementAccessXxl()
    {
        Assert.Equal(980, matrixDirectXXL.GetIndices(Element_980_890_XXL).i);
        Assert.Equal(890, matrixDirectXXL.GetIndices(Element_980_890_XXL).j);
    }

    [Fact]
    public void RecursiveElementAccessXxl()
    {
        Assert.Equal(980, matrixRecursiveXXL.GetIndices(Element_980_890_XXL).i);
        Assert.Equal(890, matrixRecursiveXXL.GetIndices(Element_980_890_XXL).j);
    }

    [Fact]
    public void AdvancedElementAccessXxl()
    {
        Assert.Equal(980, matrixAdvancedXXL.GetIndices(Element_980_890_XXL).i);
        Assert.Equal(890, matrixAdvancedXXL.GetIndices(Element_980_890_XXL).j);
    }
}
