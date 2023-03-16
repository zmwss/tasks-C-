bool palindrome(int number)
{
    return (number/10000 == number%10 && number/1000%10 == number/10%10);
}

System.Console.WriteLine("Enter a five-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Math.Abs(n);
if(m < 10000 || m > 99999) System.Console.WriteLine("Enter a five-digit number!");
else if(palindrome(m)) System.Console.WriteLine($"The number {n} is a palindrome");
else System.Console.WriteLine($"The number {n} is not a palindrome");