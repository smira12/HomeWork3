﻿/*Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Введите число");
        }
    }

    return result;
}

void PrintSquareTable(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{i * i * i},");
    }
}

int number = GetNumber("Введите число: ");

PrintSquareTable(number);