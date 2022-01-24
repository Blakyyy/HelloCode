// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int[] array = {4, 3, 10, 23, 11, 1, 5};

int Maximum(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
return max; 
}

int Minimum(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
return min;
}

int maxx = Maximum(array);
int minn = Minimum(array);
int diff = maxx - minn;
Console.WriteLine($"The difference between maximum number and minimum number of this array equals to = {diff}");