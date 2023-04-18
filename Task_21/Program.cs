﻿int a1 = GetUserNumber("Введите значение x1: ");
int b1 = GetUserNumber("Введите значение y1: ");
int c1 = GetUserNumber("Введите значение z1: ");
int a2 = GetUserNumber("Введите значение x2: ");
int b2 = GetUserNumber("Введите значение y2: ");
int c2 = GetUserNumber("Введите значение z2: ");


double result = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2) + Math.Pow(a2 - a1, 2));
Console.WriteLine($"x1 ({a1},{b1},{c1}); y1 ({a2},{b2},{c2}) -> {result:f2}");

static int GetUserNumber(string message)
{
    while (true)
    {
        Console.Write(message);
        int userInput;
        if (int.TryParse(Console.ReadLine(), out userInput))
        {
            return userInput;
        }
        else Console.WriteLine("Вы ввели некорректные данные ");
    }
}