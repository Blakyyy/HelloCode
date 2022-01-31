// Найти сумму элементов от M до N, N и M заданы
int sum = 0;
int Sum(int m, int n)
{
    if(m <= n)
    {
        return m+Sum(m+1, n); 
    }
    return 0;
}
Console.WriteLine("Choose first number ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Choose second number ");
int n = Convert.ToInt32(Console.ReadLine());
Sum(m, n);
Console.WriteLine(Sum(m,n));
