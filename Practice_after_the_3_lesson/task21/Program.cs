double distance(double xA, double yA, double zA,
                double xB, double yB, double zB)
{
    return Math.Sqrt((xA-xB)*(xA-xB) + (yA-yB)*(yA-yB) + (zA-zB)*(zA-zB));
}

System.Console.WriteLine("Enter the coordinates of point A: ");
System.Console.Write("x =");
double xA = Convert.ToDouble(Console.ReadLine());
System.Console.Write("y =");
double yA = Convert.ToDouble(Console.ReadLine());
System.Console.Write("z =");
double zA = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Enter the coordinates of point B: ");
System.Console.Write("x =");
double xB = Convert.ToDouble(Console.ReadLine());
System.Console.Write("y =");
double yB = Convert.ToDouble(Console.ReadLine());
System.Console.Write("z =");
double zB = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"Distance between points A and B equals {distance(xA, yA, zA, xB, yB, zB)}");