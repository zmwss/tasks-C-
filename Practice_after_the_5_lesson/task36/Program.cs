void PrintArray(int [] arr)
{
    int length = arr.Length;
    int i = 0;
    while(i < length)
    {
        System.Console.Write($"{arr[i]} ");
        i++;
    }
    System.Console.WriteLine();
}

void FillArray(int[] arr)
{
    int length = arr.Length;
    int i = 0;
    while (i < length)
    {
        arr[i] = new Random().Next(-100, 101);
        i++;
    }
}

int SumOddIndex(int[] arr)
{
    int sum = 0;
    int length = arr.Length;
    for(int i = 1; i < length; i+=2)
    {
        sum+=arr[i];
    }
    return sum;
}

int [] array = new int[4];
FillArray(array);
PrintArray(array);
System.Console.WriteLine($"The sum of the elements in odd positions: {SumOddIndex(array)}");

