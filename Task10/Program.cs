﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное цисло: ");
int number = int.Parse(Console.ReadLine());
Console.Write($" Вторая цифра числа{number} является {(number / 10) % 10} ");