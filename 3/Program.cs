int N = 10;

int[] arr = new int[N];

string rec(int[] n)
{
    int m = n.Length;
    if (m == 0)
    {
        return "";
    }
    return rec(m - 1) + $"{m} ";
}

Console.WriteLine(rec(N));