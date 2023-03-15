int second_digit(int number)
{
    number/=10;
    return number%10;
}

Console.Write("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(Math.Abs(number)<100 || Math.Abs(number)>999)
{
    Console.WriteLine("Enter three-digit number!");
    return;
}

else Console.WriteLine($"The second digit of {number} is {second_digit(Math.Abs(number))}");