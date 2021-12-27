// Найти третью цифру числа или сообщить, что её нет
int number = new Random().Next(1, 1000);
int thirddigit = number/100;
if (thirddigit < 1)
{
    Console.WriteLine("Your number " + number + " doesnt have three digits");
}
else
{
    Console.WriteLine("Your number is " + number + " does have third digit - " + thirddigit);
}