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

void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
            arr[i,j] = new Random().Next(0, 10);
    }
}

bool IsElemIJ(int[,] arr, int i, int j)
{
    if(i > arr.GetLength(0) || j > arr.GetLength(1)) return false;
    return true;
}
int m = 5, n = 4;
int[,] array = new int[m,n];
Console.WriteLine("Enter the row number");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the column number");
int j = Convert.ToInt32(Console.ReadLine());
FillArray(array);
PrintArray(array);
if(IsElemIJ(array, i, j)) Console.WriteLine($"{array[i, j]}");
else Console.WriteLine("There is no element with this number");
