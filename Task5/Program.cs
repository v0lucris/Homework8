// Написать программу возведения числа А в целую стень B


int DegreeNumber (int A, int B)
{
    if (B < 1 ) return 1;
    return A * DegreeNumber ( A, B - 1);
}
Console.WriteLine("Input number A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Input number B");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($" А в степени В равно : {DegreeNumber ( A, B)}");