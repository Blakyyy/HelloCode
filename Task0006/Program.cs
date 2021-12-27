// 6. Выяснить является ли число чётным
int number = new Random().Next(1, 11);
int ostatok = number % 2; // При деление числа на 2 берется его остаток с помощью %
if (ostatok == 0)
    {
        Console.WriteLine("Число четное - " + number);
    }
else
{
    Console.WriteLine("Число не четное - " + number);
}