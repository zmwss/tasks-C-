void PrintArray3D(int[,,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    int k = arr.GetLength(2);
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            for(int l = 0; l < k; l++)
            {
                Console.Write($"{arr[i,j,l]}({i},{j},{l}) ");
            }
        }
        Console.WriteLine();
    }
}
int[] GetUniqueValues(int length)
{
    int[] unique = new int[length];
    for(int i = 0; i < length; i++)
    {
        bool flag = true;
        int value = new Random().Next(10, 100);
        for(int j = 0; j < i; j++)
        {
            if(unique[j] == value) 
            {
                i--;
                flag = false;
                break;
            }
        }
        if(flag)
        unique[i] = value;
    }
    return unique;
}
void FillUniqueArray(int[,,] arr, int[] unique)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    int k = arr.GetLength(2);
    for(int i = 0, ind = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            for(int l = 0; l < k; l++, ind++)
            {
                arr[i,j,l] = unique[ind];
            }
        }
    }
}

Console.WriteLine("Enter the length of the 1-st dimension:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the length of the 2-nd dimension:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the length of the 3-rd dimension:");
int k = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[m,n,k];
FillUniqueArray(array,GetUniqueValues(m*n*k));
PrintArray3D(array);