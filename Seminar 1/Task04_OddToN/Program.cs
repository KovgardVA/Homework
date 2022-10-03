﻿// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Эта программа покажет Вам все натуральные четные числа до введенного!");
Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine("О, нет! Это это же не натуральное число :(");
}
else
{
    Console.Write($"А вот и все четные числа от 1 до {N}:");
    for (int i = 1; i <= N; i++)
    {
        if(i % 2 == 0)
        {
            Console.Write($" {i}");
        }
    }
}