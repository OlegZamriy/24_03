using System;

public static class PointExtensions
{
    public static event EventHandler<Tuple<Point3D, Point3D, double>> MaxDistanceCalculated;

    public static double CalculateMaxDistance(this Point3D[] points)
    {
        double maxDistance = 0;
        Point3D maxPointA = null;
        Point3D maxPointB = null;

        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                double distance = points[i].CalculateDistanceTo(points[j]);
                if (distance > maxDistance)
                {
                    maxDistance = distance;
                    maxPointA = points[i];
                    maxPointB = points[j];
                }
            }
        }

        MaxDistanceCalculated?.Invoke(null, new Tuple<Point3D, Point3D, double>(maxPointA, maxPointB, maxDistance));
        return maxDistance;
    }
}
