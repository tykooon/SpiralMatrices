using System.Diagnostics;
using SpiralMatrices.Core;

var sw = new Stopwatch();
sw.Start();
var matrixDirect = new SpiralMatrixDirect(10000, 10000);
Console.WriteLine(matrixDirect[4000, 4500]);
sw.Stop();
Console.WriteLine($"SpiralMatrix with Direct Approach: {sw.Elapsed.ToString()}");

sw.Restart();
var matrixRecursive = new SpiralMatrixRecursive(10000, 10000);
Console.WriteLine(matrixRecursive[4000, 4500]);
sw.Stop();
Console.WriteLine($"SpiralMatrix with Recursive Approach: {sw.Elapsed.ToString()}");