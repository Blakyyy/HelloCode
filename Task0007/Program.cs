//Показать числа от -N до N
Console.WriteLine("Введите отрицацельное число - ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выводим числа от отрицательного до положительного");
for (int i = number; i<=Math.Abs(number); i++)
{
    Console.WriteLine(i);
}