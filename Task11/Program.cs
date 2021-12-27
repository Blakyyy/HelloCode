// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int number = new Random().Next(10, 100);
int firstnumber = number%10;
int secondnumber = (number%100)/10;
if (firstnumber > secondnumber)
{
    Console.WriteLine(number + " Цифра - " + firstnumber);
}
else
{
    Console.WriteLine(number + " Цифра - " + secondnumber);
}