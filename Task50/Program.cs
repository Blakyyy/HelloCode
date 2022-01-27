// В двумерном массиве n×k заменить четные элементы на противоположные
int n = 3;
int k = 3;
int[,] array = new int[n, k];
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < k; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine(" ");
}
Console.WriteLine(" ");

int[,] ChangeNum(int[,] array)
{
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < k; j++)
        {
            if (array[i, j] % 2 == 0)
            {
                array[i, j] = -array[i, j];
            }
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine(" ");
    } 
    return array;
}

ChangeNum(array);