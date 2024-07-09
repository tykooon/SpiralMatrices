using BenchmarkDotNet.Running;
using System.Reflection;

BenchmarkSwitcher
    .FromAssembly(Assembly.GetExecutingAssembly())
    .Run(args);

/*
const int BIG_ROWS = 4; // 9000;
const int BIG_COLS = 6; // 9000;
const int BIG_I = 4501;
const int BIG_J = 4499;
const int PRINT_ROWS = 100;
const int PRINT_COLS = 20;
const int BIG_ELEMENT = 15; // 69991997;
var sw = new Stopwatch();

//var matrixDirect = new SpiralMatrixDirect(BIG_ROWS, BIG_COLS);
//sw.Start();
//Console.WriteLine(matrixDirect[BIG_I, BIG_J]);
//sw.Stop();
//Console.WriteLine($"SpiralMatrix with Direct Approach: {sw.Elapsed}");

//var matrixRecursive = new SpiralMatrixRecursive(BIG_ROWS, BIG_COLS);
//sw.Restart();
//Console.WriteLine(matrixRecursive[BIG_I, BIG_J]);
//sw.Stop();
//Console.WriteLine($"SpiralMatrix with Recursive Approach: {sw.Elapsed}");

//var matrixAdvanced = new SpiralMatrixAdvanced(BIG_ROWS, BIG_COLS);
//sw.Restart();
//Console.WriteLine(matrixAdvanced[BIG_I, BIG_J]);
//sw.Stop();
//Console.WriteLine($"SpiralMatrix with Advanced Approach: {sw.Elapsed}");


//var mDir = new SpiralMatrixDirect(PRINT_ROWS, PRINT_COLS);
//var mRec = new SpiralMatrixRecursive(PRINT_ROWS, PRINT_COLS);
//var mSci = new SpiralMatrixAdvanced(PRINT_ROWS, PRINT_COLS);

//sw.Restart();
//mDir.PrintOut();
//sw.Stop();
//Console.WriteLine($"SpiralMatrix with Direct Approach: {sw.Elapsed}");


//sw.Restart();
//mRec.PrintOut();
//sw.Stop();
//Console.WriteLine($"SpiralMatrix with Recursive Approach: {sw.Elapsed}");

//sw.Restart();
//mSci.PrintOut();
//sw.Stop();
//Console.WriteLine($"SpiralMatrix with Advanced Approach: {sw.Elapsed}");

//var matrixDirForElement = new SpiralMatrixDirect(BIG_ROWS, BIG_COLS);
//sw.Restart();
//Console.WriteLine($"Direct approach indices for {BIG_ELEMENT} in matrix" +
//    $" {BIG_ROWS}x{BIG_COLS} : {matrixDirForElement.GetIndices(BIG_ELEMENT)}");
//sw.Stop();
//Console.WriteLine($"SpiralMatrix with Direct Approach: {sw.Elapsed}");



var matrixRecForElement = new SpiralMatrixRecursive(BIG_ROWS, BIG_COLS);

sw.Restart();

Console.WriteLine($"Recursive approach indices for {BIG_ELEMENT} in matrix" +
    $" {BIG_ROWS} x {BIG_COLS} : {matrixRecForElement.GetIndices(BIG_ELEMENT)}");

sw.Stop();

Console.WriteLine($"SpiralMatrix with Recursive Approach: {sw.Elapsed}");

var matrixAdvForElement = new SpiralMatrixAdvanced(BIG_ROWS, BIG_COLS);

sw.Restart();
Console.WriteLine($"Advanced approach indices for {BIG_ELEMENT} in matrix" +
    $" {BIG_ROWS} x {BIG_COLS} : {matrixAdvForElement.GetIndices(BIG_ELEMENT)}");
sw.Stop();

Console.WriteLine($"SpiralMatrix with Recursive Approach: {sw.Elapsed}");

for (var i = 1; i <= 24; i++)
{
    Console.WriteLine(matrixAdvForElement.GetIndices(i));
}


*/