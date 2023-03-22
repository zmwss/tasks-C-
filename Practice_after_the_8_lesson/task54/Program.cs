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

void SortArray(int[,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            for(int k = 0; k < n-j-1; k++)
            {
                if(arr[i,k] < arr[i,k+1])
                {
                    int temp = arr[i,k];
                    arr[i,k] = arr[i,k+1];
                    arr[i,k+1] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Enter the number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
FillArray(array);
PrintArray(array);
SortArray(array);
PrintArray(array);