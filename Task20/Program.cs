// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Выберите номер четверти - (1, 2, 3, 4)?");
int partnumber = Convert.ToInt32(Console.ReadLine());
if (partnumber == 1)
{
    Console.WriteLine("Диапазон возможных координат - (+Infinity, +Infinity");
}
else if (partnumber == 2)
{
    Console.WriteLine("Диапазон возможных координат - (-Infinity, +Infinity)");
}
else if (partnumber == 3)
{
    Console.WriteLine("Диапазон возможных координат - (-Infinity, -Infinity)");
}
else
{
    Console.WriteLine("Диапазон возможных координат - (+Infinity, -Infinity)");
}
