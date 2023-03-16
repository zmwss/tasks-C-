System.Console.WriteLine("Enter a number A");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter a natural number B");
int b = Convert.ToInt32(Console.ReadLine());
if(b < 1)
{
    System.Console.WriteLine("Enter a natural number B!");
    return;
}
double aCopy = a;
for(int i = 1; i < b; i++)
{
    a*=aCopy;
}

System.Console.WriteLine($"A to the power of B: {a}");