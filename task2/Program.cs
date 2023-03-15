Console.WriteLine("Enter an integer number a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an integer number b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The maximum of the numbers {a} and {b}: {(a > b ? a: b)}");