//  Написать программу вычисления значения функции y = f(a)
int f(int arg1, int arg2)  //Имя функции "f" - (тип данных + агрументы)
 {   int max = arg1;         // Расписывание функциональности функции
    if (arg2 > max)
    {
        max = arg2;
    }
    return max;
 }
int result = f(new Random().Next(1, 11), new Random().Next(1, 11));  // Использование функции и добавление переменной
Console.WriteLine(result);
