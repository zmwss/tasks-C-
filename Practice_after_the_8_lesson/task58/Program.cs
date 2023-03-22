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

int[,] ProductMatrix(int[,] A, int[,] B)
{
    int m1 = A.GetLength(0);
    int n1 = A.GetLength(1);
    int m2 = B.GetLength(0);
    int n2 = B.GetLength(1);
    int[,] C = new int[m1, n2];
    for(int i = 0; i < m1; i++)
    {
        for(int j = 0; j < n2; j++)
        {
            for(int l = 0; l < n1; l++)
            {
                C[i,j]+=A[i,l]*B[l,j];
            }
        }
    }
    return C;
}

Console.WriteLine("Enter the number of rows of the matrix A");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns of the matrix A");
int n1 = Convert.ToInt32(Console.ReadLine());
int[,] A = new int[m1,n1];
Console.WriteLine("Enter the number of rows of the matrix B");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns of the matrix B");
int n2 = Convert.ToInt32(Console.ReadLine());
int[,] B = new int[m2,n2];
FillArray(A);
FillArray(B);
Console.WriteLine("Matrix A: ");
PrintArray(A);
Console.WriteLine("Matrix B: ");
PrintArray(B);
if(n1 != m2) Console.WriteLine("Matrix A*B is undefined. The number of columns of the matrix A is not equal to the number of rows of the matrix B");
else 
{
    Console.WriteLine("Matrix A*B:");
    PrintArray(ProductMatrix(A, B));
}