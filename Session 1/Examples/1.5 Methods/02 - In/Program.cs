Point3D p1;
p1.X = -1;
p1.Y = 0;
p1.Z = -1;

Point3D p2;
p2.X = 1;
p2.Y = 2;
p2.Z = 3;

Console.WriteLine($"The distance between {p1} and {p2} is {CalculateDistance(p1, p2)}");

static double CalculateDistance( in Point3D first, in Point3D second )
{
    double xDiff = first.X - second.X;
    double yDiff = first.Y - second.Y;
    double zDiff = first.Z - second.Z;

    return Math.Sqrt(xDiff * xDiff + yDiff * yDiff + zDiff * zDiff);
}
