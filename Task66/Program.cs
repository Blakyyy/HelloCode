// Показать натуральные числа от 1 до N, N задано
void PrintArray(int n, int i = 1)
{
    Console.Write($"{i} ");
    if (i != n)
        PrintArray(n, i + 1);
}

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
PrintArray(N);
