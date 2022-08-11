/*
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число:");
string? number = Console.ReadLine();
Console.Write ("Вторая цифра-" + number[1]);


Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

Console.Write ("Введите число: ");
string? number = Console.ReadLine();
if (number.Length > 2)
{
    Console.Write("Третья цифра числа - "+(number[2]));
}
else
{
    Console.Write("Третьей цифры нет");
}


Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
*/

Console.Write ("Введите число от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber <= 5)
{
    Console.Write("Нет");
}
else
{
    Console.Write ("Да");
}

