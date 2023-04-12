/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

int number = 0;

Console.Write("Enter the numder: ");

if (int.TryParse(Console.ReadLine(), out number))
{
    if (number % 2 == 0)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
else
{
    Console.WriteLine("oops");
}