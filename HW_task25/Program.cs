﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵), 2, 4 -> 16
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = a;

for (int i = 1; i < b; i++)
{
result = result * a;
}
Console.WriteLine(result);