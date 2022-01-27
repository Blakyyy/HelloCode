//Показать двумерный массив размером m×n заполненный целыми числами
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