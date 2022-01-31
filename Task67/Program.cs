// Показать натуральные числа от N до 1, N задано
void PrintArray(int n)
{
    Console.Write($"{n} ");
    if (n != 1)
        PrintArray(n - 1);
}

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
PrintArray(N);
