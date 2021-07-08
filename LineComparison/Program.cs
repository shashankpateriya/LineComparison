using System;
namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Computation.");
            LineComparison line = new LineComparison();
            double[] lineLength = new double[2];
            for (int numOfLines = 0; numOfLines < 2; numOfLines++)
            {
                lineLength[numOfLines] = line.CalculateLength();
            }
            line.CompareLength(lineLength[0], lineLength[1]);
        }
    }
}