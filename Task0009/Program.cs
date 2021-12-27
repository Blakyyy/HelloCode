//Показать последнюю цифру трёхзначного числа
int number = new Random().Next(100, 1000);
int lastdigit = number%10;
Console.WriteLine(number + " Последняя цифра - " + lastdigit);