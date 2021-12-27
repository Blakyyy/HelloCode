//Показать четные числа от 1 до N
int n1 = 1;
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
while (n1 <= N)
{
    if(n1%2 == 0)
    {
        Console.WriteLine(n1);
        n1++;
    }
    else
        n1++;
}