﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое число из трёх чисел: - ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число из трёх чисел: - ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третие число из трёх чисел: - ");
int number3 = int.Parse(Console.ReadLine());
int max = number1;
if (number2 > number1)
    max = number2;
if (number3 > max)
    max = number3;
Console.Write("Максимальное число " + max);

// Console.WriteLine("Hello, World!");
