// Выяснить являются ли три числа сторонами треугольника
int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);
int c = new Random().Next(1, 10);
if (a+b>c && a+c>b && c+b>a)
{
    System.Console.WriteLine($"A = {a} , B = {b}, C = {c}, All 3 numbers form a triangle");
}
else
{
    System.Console.WriteLine($"A = {a} , B = {b}, C = {c}, All 3 numbers DONT form a triangle");
}