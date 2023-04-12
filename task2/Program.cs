/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int max = 0;

Console.Write("Enter the number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

max = number1;

if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}

Console.WriteLine($"max = {max}");