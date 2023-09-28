// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int num =Convert.ToInt32(Console.ReadLine());

if(num == 1)
{
    Console.WriteLine("Понедельник - нет");
}
else if(num == 2)
{
    Console.WriteLine("Вторник - нет");
}
else if(num == 3)
{
    Console.WriteLine("Среда - нет");
}
else if(num == 4)
{
    Console.WriteLine("Четверг - нет");
}
else if(num == 5)
{
    Console.WriteLine("Пятница - нет");
}
else if(num == 6)
{
    Console.WriteLine("Суббота - да");
}
else if(num == 7)
{
    Console.WriteLine("Воскресенье - да");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}