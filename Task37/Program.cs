// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] array = new int[123];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    if (array[i] > 10)
    {
        count++;
    }
}
Console.WriteLine($"В вашем массиве {count} элементов из отрезка [10. 99]");
