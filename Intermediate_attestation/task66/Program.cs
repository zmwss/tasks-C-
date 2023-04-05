int SumNumbersFromMtoN(int M, int N)
{
    if(M > N) return 0;
    else if(M==N) return M;
    return M+N+SumNumbersFromMtoN(M+1, N-1);
}

Console.Write("Enter a natural number M: ");
int M = Convert.ToInt32(Console.ReadLine());
if(M < 1)
{
    Console.WriteLine("You entered non-natural number.");
    return;
}
Console.Write("Enter a natural number N: ");
int N = Convert.ToInt32(Console.ReadLine());
if(N < 1)
{
    Console.WriteLine("You entered non-natural number.");
    return;
}
Console.WriteLine($"The sum of the numbers from {M} to {N} {SumNumbersFromMtoN(M, N)}");