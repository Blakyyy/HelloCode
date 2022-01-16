// Показать кубы чисел, заканчивающихся на четную цифру
for (int i = 1; i < 50; i++)
{
    int lastdigit = i % 10;
    int cubeNumber = i * i * i;
    if (lastdigit == 2)
    {
        Console.WriteLine($"Ваше число {i} и кую вашего числа = {cubeNumber}");
    }
    else if (lastdigit == 4) 
    {
        Console.WriteLine($"Ваше число {i} и кую вашего числа = {cubeNumber}");
    }
    else if (lastdigit == 6)
    {
        Console.WriteLine($"Ваше число {i} и кую вашего числа = {cubeNumber}");
    }
    else if (lastdigit == 8)
    {
        Console.WriteLine($"Ваше число {i} и кую вашего числа = {cubeNumber}");
    }
    else if (lastdigit == 0)
    {
        Console.WriteLine($"Ваше число {i} и кую вашего числа = {cubeNumber}");
    }
    else
    {
        Console.WriteLine($"Ваше число {i} не заканчивается на четную цифру");
    }
}