﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int num =Convert.ToInt32(Console.ReadLine());
int result=0;

if(num < 100 || num >=1000)
{
    Console.WriteLine("Введенное число не является трехзначным");
}
else
{
    result = num/10%10;
    Console.WriteLine(result);
}