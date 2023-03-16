int sum_digits(int n)
{
    int sum = 0;
    while(n > 0)
    {
        sum+=n%10;
        n/=10;
    }
    return sum;
}

System.Console.WriteLine("Enter a number n");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"The sum of the digits of the {n} equals {sum_digits(Math.Abs(n))}");