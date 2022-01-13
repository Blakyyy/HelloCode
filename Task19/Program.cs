//  Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите координаты для X - ");
int xcoordinates = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты для Y - ");
int ycoordinates = Convert.ToInt32(Console.ReadLine());
if (xcoordinates > 0 && ycoordinates > 0)
{
    Console.WriteLine("Ваши координаты находятся в первой четверти");
}
else if (xcoordinates < 0 && ycoordinates > 0)
{
    Console.WriteLine("Ваши координаты находятся во второй четверти");
}
else if (xcoordinates < 0 && ycoordinates <0)
{
    Console.WriteLine("Ваши координаты находятся в третей четверти");
}
else if(xcoordinates > 0 && ycoordinates < 0)
{
    Console.WriteLine("Ваши координаты находятся в четвертой четверти");
}
else
{
    Console.WriteLine(" Ошибка. Введите другие координаты");
}