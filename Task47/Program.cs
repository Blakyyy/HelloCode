// Написать программу копирования массива
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i]);
    Console.Write(" ");
}
Console.WriteLine(" ");
int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}
void PrintArray(int[] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
    {
        Console.Write(newArray[i]);
        Console.Write(" ");
    }
}
int[] newArray = CopyArray(array);
PrintArray(newArray);
