Console.Clear();

Console.WriteLine("Введите значения M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значения N: ");
int n = Convert.ToInt32(Console.ReadLine());

string rec(int n)
{
    if (n == m)
      return "";
    return rec(n - 1) + $"{n} ";
}

Console.WriteLine(rec(n));