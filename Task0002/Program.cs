// Даны два числа. Показать большее и меньшее число
int number1 = new Random().Next(1, 101);
int number2 = new Random().Next(1, 101);
if(number1 > number2)
{
    Console.WriteLine("Первое число - " + number1 + " больше второго - " + number2);
}
else if(number1 == number2) 
{
    Console.WriteLine("Первое число - " + number1 + " равно вторуму числу - " + number2);
}
else
{
    Console.WriteLine("Первое число - " + number1 + " Меньше второго числа - " + number2);
}
