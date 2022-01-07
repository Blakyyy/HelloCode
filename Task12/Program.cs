//Удалить вторую цифру трёхзначного числа
int number = new Random().Next(100, 1000);
int thirddigit = number/100;
int seconddigit = (number%100)/10;
int firstdigit = (number%100)%10;
Console.WriteLine(number + " Второй - " + thirddigit + firstdigit);