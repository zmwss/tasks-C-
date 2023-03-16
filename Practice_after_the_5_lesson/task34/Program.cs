int NumberOfEven(int [] array)
{
    int number = 0;
    int length = array.Length;
    for(int i = 0; i < length; i++)
    {
        if(array[i]%2 == 0) number+=1;
    }
    return number;
}

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
        arr[i] = new Random().Next(100, 1000);
        i++;
    }
}

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);
System.Console.WriteLine($"Number of even elements: {NumberOfEven(arr)}");