// 60. Составить частотный словарь элементов двумерного массива
int[,] array = new int[5, 5];
int rows = 5;
int table = 5;
int count1 = 0;
int count2 = 0;
int count3 = 0;
int count4 = 0;
int count5 = 0;
int count6 = 0;
int count7 = 0;
int count8 = 0;
int count9 = 0;
int percentof = rows * table;


void FillArray(int[,] array)
{
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < table; j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < table; j++)
        {
            Console.Write(array[i,j]);
            Console.Write(" ");
        }
        Console.WriteLine(" ");
    }
}

void FindingNumber(int[,] array)
{
     for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < table; j++)
        {
            if(array[i,j] == 1)
            {
                count1 = count1 + 1;
            }
            else if(array[i,j] == 2)
            {
                count2 = count2 + 1;
            }
            else if(array[i,j] == 3)
            {
                count3 = count3 + 1;
            }
            else if(array[i,j] == 4)
            {
                count4 = count4 + 1;
            }
            else if(array[i,j] == 5)
            {
                count5 = count5 + 1;
            }
            else if(array[i,j] == 6)
            {
                count6 = count6 + 1;
            }
            else if(array[i,j] == 7)
            {
                count7 = count7 + 1;
            }
            else if(array[i,j] == 8)
            {
                count8 = count8 + 1;
            }
            else if(array[i,j] == 9)
            {
                count9 = count9 + 1;
            }
        }
    }
    double count1p = (count1 * 100)/percentof;
    double count2p = (count2 * 100)/percentof;
    double count3p = (count3 * 100)/percentof;
    double count4p = (count4 * 100)/percentof;
    double count5p = (count5 * 100)/percentof;
    double count6p = (count6 * 100)/percentof;
    double count7p = (count7 * 100)/percentof;
    double count8p = (count8 * 100)/percentof;
    double count9p = (count9 * 100)/percentof;
    Console.WriteLine($"1 встречается {count1} раза, вероятность = {count1p}%");
    Console.WriteLine($"2 встречается {count2} раза, вероятность = {count2p}%");
    Console.WriteLine($"3 встречается {count3} раза, вероятность = {count3p}%");
    Console.WriteLine($"4 встречается {count4} раза, вероятность = {count4p}%");
    Console.WriteLine($"5 встречается {count5} раза, вероятность = {count5p}%");
    Console.WriteLine($"6 встречается {count6} раза, вероятность = {count6p}%");
    Console.WriteLine($"7 встречается {count7} раза, вероятность = {count7p}%");
    Console.WriteLine($"8 встречается {count8} раза, вероятность = {count8p}%");
    Console.WriteLine($"9 встречается {count9} раза, вероятность = {count9p}%");
}

FillArray(array);
PrintArray(array);
FindingNumber(array);
