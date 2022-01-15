Console.WriteLine("Вебирите число для N ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
int result = 0;
for (i = 1; i <= N; i++)
{
    result += i;
}
Console.WriteLine(result);