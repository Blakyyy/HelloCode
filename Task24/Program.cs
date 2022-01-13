// Найти кубы чисел от 1 до N
int n = new Random().Next(1, 11);
int i = 1;
while (i < n)
{
    int squarenumbers = i * i * i;
    Console.WriteLine("Куб числа " + i + " = " + squarenumbers);
    i++;
}