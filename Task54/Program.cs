//  В матрице чисел найти сумму элементов главной диагонали
int[,] array = new int[3, 3];
int rows = 3;
int table = 3;
int sum = 0;
void CreateArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < table; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < table; j++)
        {
            Console.Write(array[i,j]);
            Console.Write(" ");
        }
        Console.WriteLine(" ");   
    }      
}

void FindSum(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < table; j++)
        {
            if(i == j)
            {
                sum = sum + array[i, j];
            }
        }
    }
}
CreateArray(array);
PrintArray(array);
FindSum(array);
Console.WriteLine($"Сумма элементов главной диагонали = {sum}");