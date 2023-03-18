int[] InputArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        Console.WriteLine($"Enter the {i}-th number");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int PositiveNumbers(int [] arr)
{
    int number = 0;
    int length = arr.Length;
    for(int i = 0; i < length; i++)
    if(arr[i] > 0) number++;
    return number;
}

Console.WriteLine("Enter the number of numbers");
int length = Convert.ToInt32(Console.ReadLine());
int number = PositiveNumbers(InputArray(length));
Console.WriteLine($"You have entered {number} numbers greater than zero");