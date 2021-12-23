int number1 = new Random().Next(1, 11);
int number2 = new Random().Next(1, 11);
int number3 = new Random().Next(1, 11);
int max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.WriteLine("Первок число - " + number1 + " Второе число - " + number2 + " Третье число - " + number3 + " и максимальное из трех чисел это - " + max);
