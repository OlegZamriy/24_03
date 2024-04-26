using System;

class Program
{
    static void Main()
    {
        Point3D[] points = new Point3D[]
        {
            new Point3D(1, 2, 3),
            new Point3D(-2, 5, 7),
            new Point3D(0, 0, 0),
            new Point3D(10, -5, 8)
        };

        double maxDistance = points.CalculateMaxDistance();

        Console.WriteLine($"Максимальна відстань між точками: {maxDistance}");

        PointExtensions.MaxDistanceCalculated += MaxDistanceCalculatedHandler;
    }

    static void MaxDistanceCalculatedHandler(object sender, Tuple<Point3D, Point3D, double> result)
    {
        Console.WriteLine($"Подія: максимальна відстань між точками {result.Item1.X},{result.Item1.Y},{result.Item1.Z} і {result.Item2.X},{result.Item2.Y},{result.Item2.Z} = {result.Item3}");
    }
}
