void FillArray(int[] arr)
{
    int length = arr.Length;
    int i = 0;
    Random rnd = new Random();
    while (i < length)
    {
        arr[i] = rnd.Next();
        i++;
    }
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
}

int [] array = new int[8];
FillArray(array);
PrintArray(array);