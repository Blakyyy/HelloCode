int number1 = new Random().Next(10, 100);
int number2 = new Random().Next(2, 11);
int ostatok = number1%number2;
if (ostatok == 0)
{
    Console.WriteLine("Число первое " + number1 + " кратно второму числу - " + number2);
}
else
{
    Console.WriteLine("Первое число " + number1 + " не кратно второму " + number2 + " остаток - " + ostatok);
}