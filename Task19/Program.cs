// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);

if (9999 < N && N < 100000)
{
    if (N % 10 == N / 10000 && (N / 1000) % 10 == (N % 100) / 10)
    {
        Console.WriteLine("Число является полиндромом? - Да!");
    }
    else
    {
        Console.WriteLine("Число является полиндромом? - Нет!");
    }
}
else
{
    Console.WriteLine("Неверное значение!");
}