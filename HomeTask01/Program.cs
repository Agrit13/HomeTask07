// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

int ReadInt(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int NaturDigit(int m, int n)
{
    if (n >= m) 
        System.Console.Write($"{m} ");
        return NaturDigit(m+1, n);
       
}

int M = ReadInt("Введите первое число: ");
int N = ReadInt("Введите второе число: ");
System.Console.WriteLine(NaturDigit(M, N));

