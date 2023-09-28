// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num =Convert.ToInt32(Console.ReadLine());


if(num > 999)
{
    num /= 100;
    Console.WriteLine(num%10);
}
else if(num > 99 || num <1000)
{
    Console.WriteLine(num%10);
}
else if(num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}