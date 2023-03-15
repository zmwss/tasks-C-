Console.WriteLine("Enter an natural number N");
uint N = Convert.ToUInt32(Console.ReadLine());
 if(N < 2) Console.WriteLine($"There are no even numbers up to {N}");
 else
 {
    Console.Write($"Even numbers from 2 to {N}:");
     for(int i=2; i <= N; i+=2)
        {
            Console.Write($" {i}");
        }
 }
