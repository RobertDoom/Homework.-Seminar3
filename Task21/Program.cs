// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();

Console.Write("Введите координату X точки A: ");
int XA = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y точки A: ");
int YA = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Z точки A: ");
int ZA = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату X точки B: ");
int XB = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y точки B: ");
int YB = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Z точки B: ");
int ZB = int.Parse(Console.ReadLine()!);

double length = Math.Sqrt(Math.Pow((XA - XB), 2) + Math.Pow((YA - YB), 2) + Math.Pow((ZA - ZB), 2));

Console.WriteLine($"Расстояние между точками = {length:f2}");