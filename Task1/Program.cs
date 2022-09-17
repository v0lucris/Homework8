// Показать натуральные числа от M до N, N и M заданы



void PrintNumberNmax(int N, int M)
{
    if( N < M) return;
    PrintNumberNmax(N-1,M);
    Console.Write(N+" ");
}

void PrintNumberMmax(int N, int M)
{
    if( M < N) return;
    Console.Write(M+" ");
    PrintNumberMmax(N,M-1);
    
}

Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());


PrintNumberNmax(N,M);

PrintNumberMmax(N,M);
 

