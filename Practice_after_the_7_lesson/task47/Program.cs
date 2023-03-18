void PrintArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] arr)
{
    Random rand = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
            arr[i,j] = rand.NextDouble()*10;
    }
}
Console.WriteLine("Enter the number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];
FillArray(array);
PrintArray(array);