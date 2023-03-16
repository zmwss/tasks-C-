double DiffMaxMin(double [] arr)
{
    double max = arr[0];
    double min = arr[0];
    int length = arr.Length;
    for(int i = 1; i < length; i++)
    {
        if(max < arr[i]) max = arr[i];
        if(min > arr[i]) min = arr[i];
    }
    return max-min;
}

double[] arr = {2.5, 5.4, 7.0, -5.4, 25.3};
if(arr.Length == 0) System.Console.WriteLine("The array is empty");
else System.Console.WriteLine($"Difference between max and min: {DiffMaxMin(arr)}");
