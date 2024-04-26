using System;

public class Point3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double CalculateDistanceTo(Point3D other)
    {
        double deltaX = X - other.X;
        double deltaY = Y - other.Y;
        double deltaZ = Z - other.Z;

        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    }
}
