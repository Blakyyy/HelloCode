//Дано число. Проверить кратно ли оно 7 и 23
int number = new Random().Next(1, 10001);
int newnumber = number%7;
int newnumber2 = number%23;
if (newnumber == 0)
{
    if (newnumber2 == 0)
    {
        Console.WriteLine(number + " кратно 7 и кратно 23 ");
    }
    else
    {
        Console.WriteLine(number + " кратно 7  ,но не кратно 23"); 
    }
}
else if(newnumber2 == 0)
{
    Console.WriteLine(number + " не кратно 7, но кратно 23");
}
else
{
    Console.WriteLine(number + " не кратно 7 и не кратно 23");
}
