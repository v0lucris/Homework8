// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
int Metod(int x, int y, int num)
{
    if (num == 1) return x;
    if (num == 2) return y;
    return Metod(x, y, num - 1) + Metod(x, y, num - 2);
}

Console.WriteLine("Input number a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input number b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Input number N");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i < N; i++)
{
    Console.Write(Metod(a, b, i) + " ");
}