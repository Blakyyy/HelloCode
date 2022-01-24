// Определить сколько чисел больше 0 введено с клавиатуры
int i = 0;
int count = 0;
while (i < 5)
{
    Console.WriteLine("Please insert a nummber: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if(a > 0)
    {
        count = count + 1; 
    }
    i++;
}
Console.WriteLine($"The amount of numbers typed using keyboard higher than 0 equals to = {count}");
