// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] array = {2, 4, 1, 7, 4, 5, 7, 6};
for (int i = 0; i < array.Length; i++)
{
    int multiple = array[i] * array[array.Length - i - 1];
    Console.WriteLine($" Multiplication = {multiple}");
    if (i >= array.Length / 2 - 1) break;
}