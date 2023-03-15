int weekend(int day)
{
    if(day < 0 || day > 7) return -1;
    else return Convert.ToInt32((day == 6 || day == 7));
}

System.Console.WriteLine("Enter the number of the day of the week");
int day = Convert.ToInt32(Console.ReadLine());

int number = weekend(day);

if(number == -1) System.Console.WriteLine("Enter the number of the day of the week!");
else if(number == 1) System.Console.WriteLine("It's a weekend");
else System.Console.WriteLine("It's not a weekend");