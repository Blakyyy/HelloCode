//  Определить количество цифр в числе
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number/10;
int count = 1;
while (result !=0)
{
    result = result/10;
    count++;
}
if (result == 0)
{
    Console.WriteLine("В вашем числе " + count + " цифр");
}

