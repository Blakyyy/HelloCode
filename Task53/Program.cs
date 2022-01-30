// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
int[,] array = new int[3, 3];
int rows = 3;
int table = 3;
int count = 0;
Console.WriteLine("What number do you want to find? ");
int number = Convert.ToInt32(Console.ReadLine());

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
void SearchNumber(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < table; j++)
        {
            if(number == array[i,j])
            {
                count = count + 1;
                Console.Write($"The index of row was {i}, the index of table was {j}");
                Console.WriteLine(" ");
            }
            else if(i == rows - 1 && j == table - 1 && count == 0)
            {
                Console.Write($"Your number {number} wasnt found inside this array");
            }
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

CreateArray(array);
PrintArray(array);
SearchNumber(array);
