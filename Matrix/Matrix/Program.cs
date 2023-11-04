namespace MatrixTrace;

public class Program
{
    private static void Main(string[] args)
    {
        var matrix = new Matrix();

        Console.WriteLine("This small application will make a matrix.");

        Console.WriteLine("Please enter your row and column:\nExample: 3,2.\nWhere 3 - is Row and 2 - is Column.");

        var userRowAndColumn = Console.ReadLine().Split(",");

        matrix.MatrixRow = int.Parse(userRowAndColumn[0]);
        matrix.MatrixColumn = int.Parse(userRowAndColumn[1]);

        matrix.MakeMatrix();
        Console.WriteLine();

        matrix.ReadMatrix();
        Console.WriteLine();

        Console.WriteLine($"The sum of matrix trace is : {Matrix.FindMatrixTrace()}");
        Console.WriteLine();

        if (matrix.MatrixRow == 3)
        {
            Console.WriteLine("Snake moving in 2d dimension");
            matrix.SnakeReading();
            Console.WriteLine();
        }
    }
}