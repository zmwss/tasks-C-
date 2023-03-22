void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
            arr[i,j] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MinSumArr(int [,] arr)
{
    int minsum = 0, index = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            sum+=arr[i,j];
        }
        if(i == 0) minsum = sum;
        else if(sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    return index;
}
Console.WriteLine("Enter the number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
FillArray(array);
PrintArray(array);
Console.WriteLine($"The row with the smallest sum of elements is {MinSumArr(array)}");