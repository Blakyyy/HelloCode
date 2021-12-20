// 3. По заданному номеру дня недели вывести его название
int Monday = 1;
int Tuesday = 2;
int Wednesday = 3;
int Thursday = 4;
int Friday = 5;
int Saturday = 6;
int Sunday = 7;
int number = new Random().Next(1, 8);
if(number == Monday)
{
    Console.WriteLine("Сегодня понедельник!");
}
else if(number == Tuesday)
{
    Console.WriteLine("Сегодня вторник!");
}
else if(number == Wednesday)
{
    Console.WriteLine("Сегодня среда!");
}
else if(number == Thursday)
{
    Console.WriteLine("Сегодня четверг!");
}
else if(number == Friday)
{
    Console.WriteLine("Сегодня пятница!");
}
else if(number == Saturday)
{
    Console.WriteLine("Сегодня суббота!");
}
else
{
    Console.WriteLine("Сегодня воскресенье!");
}