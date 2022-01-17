// Написать программу замену элементов массива на противоположные
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i]);
    Console.WriteLine();
}
int[] newArray = new int[10];
for (int i = 0; i < array.Length; i++)
{
    newArray[i] = -array[i];
    Console.Write(newArray[i]);
}

