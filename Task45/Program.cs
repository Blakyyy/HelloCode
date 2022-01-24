// Показать числа Фибоначчи
int n = 1;
int n2 = 1;
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n);
Console.WriteLine(n2);
while (n2 < num )
{
    int fib = n + n2;
    n = n2;
    n2 = fib;
    if (n2 >= num) break;
    Console.WriteLine(fib);
}
