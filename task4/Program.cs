Console.WriteLine("Enter an number a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter an number b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter an number c");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"The maximum of the numbers {a} and {b} and {c}: {(a > b ? (a > c ? a : c) : (b > c ? b : c))}");