﻿// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;

while (i <= N)
{
    Console.Write(Math.Pow(i, 3));
    if (i != N)
    {
        Console.Write(", ");
    }
    i++;
}