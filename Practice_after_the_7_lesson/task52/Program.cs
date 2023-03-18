void PrintArray1(double[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void PrintArray2(int[,] arr)
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

void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
            arr[i,j] = new Random().Next(-10, 11);
    }
}
double[] ArithmeticAverageCol(int[,] arr)
{
    int numbrow = arr.GetLength(0);
    int numbcol = arr.GetLength(1);
    double[] average = new double[numbcol];
    for(int j = 0; j < numbcol; j++)
    {
        for(int i = 0; i < numbrow; i++)
        {
            average[j]+=arr[i,j];
        }
        average[j]/=numbrow;
    }
    return average;
}
Console.WriteLine("Enter the number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
FillArray(array);
PrintArray2(array);
Console.Write("The arithmetic mean of each of the columns: ");
PrintArray1(ArithmeticAverageCol(array));
