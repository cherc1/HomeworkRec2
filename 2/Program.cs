Console.WriteLine("Введите значения M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значения N: ");
int n = Convert.ToInt32(Console.ReadLine());

void func(int M, int N)
{
    if(M == 0)
    {
        return N + 1;
    }
    else if(M > 0 && N ==0)
    {
        func(M - 1);
    }
    else if( M > 0 && N > 0)
    {
        func(M - 1(func(N-1)));
    }
}

Console.WriteLine(func(m, n));