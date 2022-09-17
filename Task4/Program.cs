// Написать программу вычисления функции Аккермана
int Akkerman(int m , int n)
{
    if (m == 0) return n+1;
    else if (m > 0 && n == 0) return Akkerman(m-1,1);
    else if (m > 0 && n > 0) return Akkerman(m-1,  Akkerman(m,n-1));
    return Akkerman(m,n);
}
Console.Write("Input m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Input n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Функция Аккермана : {Akkerman(m,n)}");
