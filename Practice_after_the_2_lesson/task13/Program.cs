int third_digit(int number)
{
    if(number < 100 || number > 999) return -1;
    while(number > 999) number/=10;
    return number%10;
}

Console.Write("Enter an integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = third_digit(Math.Abs(number));
if(digit == -1) Console.WriteLine($"The number {number} doesn't have a third digit");
else Console.WriteLine($"The third digit of the number {number} is {digit}");