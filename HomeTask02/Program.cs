// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int ReadInt(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerm(int M, int N)
{
    if (M == 0)
    return N+1;

    if ((M > 0) && (N == 0))
    return Akkerm(M - 1, 1);

    else return Akkerm(M - 1, Akkerm(M, N - 1));
}
int M = ReadInt("Введите первое число: ");
int N = ReadInt("Введите второе число: ");
System.Console.WriteLine(Akkerm(M, N));

