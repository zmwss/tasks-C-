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

void FillTheSpiralArray(int[,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    int m1 = m, n1 = n;
    int i = 0, j = 0, k = 1;
    int newrow = 1, newcol = 0;
    while(m1 > 0 && n1 > 0)
    {
        while(j < n)
        {
            arr[i,j] = k;
            j++;
            k++;
        }
        j--;
        i++;
        while(i < m)
        {
            arr[i,j] = k;
            i++;
            k++;
        }
        i--;
        while(j > newcol && m1 > 1)
        {
            j--;
            arr[i,j] = k;
            k++;
        }
        newj++;
        while(i > newrow && n1 > 1)
        {
            i--;
            arr[i,j] = k;
            k++;
        }
        j++;
        newi++;
        m--;
        n--;
        m1-=2;
        n1-=2;
    }
}

int[,] array = new int[4,4];
FillTheSpiralArray(array);
PrintArray(array);