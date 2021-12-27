// Показать вторую цифру трёхзначного числа
int number = new Random().Next(100, 1000);
int seconddigit = (number%100)/10;
Console.WriteLine(number + " Вторая цифра - " + seconddigit);
  

