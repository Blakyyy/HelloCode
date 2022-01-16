// Задать массив из 8 элементов и вывести их на экран 
int[] array = new int[8];
int i = 0;
for (i = 0; i <= array.Length; i++)
{
    array[i] = new Random().Next(1, 9);
    Console.WriteLine(array[i]);
}