void PrintNumbers(int N)
{
    Console.Write($"{N} ");
    if(N > 1) PrintNumbers(N-1);
}
Console.Write("Enter a natural number: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n < 1)
{
    Console.WriteLine("You entered non-natural number.");
    return;
}
if(n > 100)
{
    Console.WriteLine("You entered too large a number for this task.");
    return;
}
PrintNumbers(n);