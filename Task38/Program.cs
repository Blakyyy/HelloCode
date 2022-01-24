// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] array = new int[20];
int sum = 0;
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.WriteLine(array[i]);
    if(i % 2 != 0)
    {
        sum += array[i];
    }
}
Console.WriteLine($"Ссума всех чисел стоящих на нечетной позиции = {sum}");
