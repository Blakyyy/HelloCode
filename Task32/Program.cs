﻿// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] array = new int[8];
int i = 0;
for (i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.WriteLine(array[i]);
}
