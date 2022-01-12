//По двум заданным числам проверять является ли одно квадратом другого
int number = new Random().Next(1, 101);
int number2 = new Random().Next(1, 11);
int numbernumber = number2 * number2;
if(numbernumber == number)
{
    Console.WriteLine("Число - " + number + " является квадратом числа - " + number2 );
}
else
{
    Console.WriteLine("Число - " + number + " не является квадратом числа - " + number2);
}