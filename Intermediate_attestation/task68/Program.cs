int ack(int M, int N)
{
    if(M==0) return N+1;
    else if(N==0) return ack(M-1, 1);
    else return ack(M-1, ack(M, N-1));
}

Console.WriteLine(ack(3,11));