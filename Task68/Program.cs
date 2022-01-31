// Показать натуральные числа от M до N, N и M заданы
void PrintArray(int n, int i)
{
    Console.Write($"{i} ");
    if (i != n)
        PrintArray(n, i + 1);
}

Console.WriteLine("Введите второе число ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
PrintArray(N, M);