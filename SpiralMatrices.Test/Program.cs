using System.Diagnostics;
using SpiralMatrices.Core;
using SpiralMatrices.Test;

const int BIG_ROWS = 10000;
const int BIG_COLS = 10000;
const int BIG_I = 4000;
const int BIG_J = 4000;
const int PRINT_ROWS = 100;
const int PRINT_COLS = 20;


var sw = new Stopwatch();
sw.Start();
var matrixDirect = new SpiralMatrixDirect(BIG_ROWS, BIG_COLS);
Console.WriteLine(matrixDirect[BIG_I, BIG_J]);
sw.Stop();
Console.WriteLine($"SpiralMatrix with Direct Approach: {sw.Elapsed}");

sw.Restart();
var matrixRecursive = new SpiralMatrixRecursive(BIG_ROWS, BIG_COLS);
Console.WriteLine(matrixRecursive[BIG_I, BIG_J]);
sw.Stop();
Console.WriteLine($"SpiralMatrix with Recursive Approach: {sw.Elapsed}");

sw.Restart();
var matrixAdvanced = new SpiralMatrixAdvanced(BIG_ROWS, BIG_COLS);
Console.WriteLine(matrixAdvanced[BIG_I, BIG_J]);
sw.Stop();
Console.WriteLine($"SpiralMatrix with Advanced Approach: {sw.Elapsed}");


var mDir = new SpiralMatrixDirect(PRINT_ROWS, PRINT_COLS);
var mRec = new SpiralMatrixRecursive(PRINT_ROWS, PRINT_COLS);
var mSci = new SpiralMatrixAdvanced(PRINT_ROWS, PRINT_COLS);

sw.Restart();
mDir.PrintOut();
sw.Stop();
Console.WriteLine($"SpiralMatrix with Direct Approach: {sw.Elapsed}");


sw.Restart();
mRec.PrintOut();
sw.Stop();
Console.WriteLine($"SpiralMatrix with Recursive Approach: {sw.Elapsed}");

sw.Restart();
mSci.PrintOut();
sw.Stop();
Console.WriteLine($"SpiralMatrix with Advanced Approach: {sw.Elapsed}");
