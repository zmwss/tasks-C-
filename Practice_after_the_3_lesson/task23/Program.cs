void print_cubes(int N)
{
    for(int i = 1; i <= N; i++)
    Console.Write($"{i*i*i} ");
}

System.Console.WriteLine("Enter a natural number: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n < 1) System.Console.WriteLine("Enter a natural number!");
else 
{
    System.Console.Write($"Cubes from 1 to {n}: ");
    print_cubes(n);
}