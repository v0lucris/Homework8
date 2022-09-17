// Найти сумму элементов от M до N, N и M заданы

Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());




int Sum1(int m, int n)
{
    if (n == m ) return n;
    return m + Sum1(m + 1, n);
}


int Sum2(int m, int n)
{
    if (n == m ) return n;
    return m + Sum2(m - 1, n);
}



if (m < n) Console.WriteLine(Sum1(m, n));
else Console.WriteLine(Sum2(m, n));



