//Показать четные числа от 1 до N
int number1 = 1;
int number2 = 20;
while (number1 <= number2)
{
    if(number1%2 == 0)
    {
        Console.WriteLine(number1); number1 = number1 + 1;
    }
}