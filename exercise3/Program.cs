﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) //Проверка равенства остатка от деления res на 2 равняется нулю
{
    Console.WriteLine("Вы ввели четное число: " +num);
}

else
{
    Console.WriteLine("Вы ввели нечетное число: " +num);
}