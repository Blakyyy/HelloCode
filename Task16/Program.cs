// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int number = new Random().Next(1, 8);
if(number > 5)
{
    Console.WriteLine(number + " - Сеголня выходной");
}
else
{
    Console.WriteLine(number + " - Сегодня рабочий день");
}