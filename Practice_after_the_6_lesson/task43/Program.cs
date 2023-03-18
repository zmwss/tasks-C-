int IsIntersect(double k1, double b1, double k2, double b2)
{
    if(k1 == k2)
    {
        if(b1 == b2) return -1;
        else return 0;
    }
    return 1;
}

double PointOfIntersectionX(double k1, double b1, double k2, double b2)
{
    return (b1-b2)/(k2-k1);
}

Console.WriteLine("Enter the angle of inclination of the line A");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter a constant for the line A");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the angle of inclination of the line B");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter a constant for the line B");
double b2 = Convert.ToDouble(Console.ReadLine());
int value = IsIntersect(k1, b1, k2, b2);
if(value == -1) Console.WriteLine("Lines A and B coincide");
else if(value == 0) Console.WriteLine("Lines A and B do not intersect");
else 
{
    double x = PointOfIntersectionX(k1, b1, k2, b2);
    double y = k1*x+b1;
    Console.WriteLine($"Point of intersection A and B ({x},{y})");
}