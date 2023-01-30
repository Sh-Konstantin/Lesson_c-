/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трехзначное число");
Console.WriteLine();
string? Number = Console.ReadLine();
while (Number.Length != 3)
    {
        Console.Write("Введите трехзначное число");
        Console.WriteLine();
        Number = Console.ReadLine();
    } 
Console.WriteLine ( $"вторая цифра трехначного числа: {Number [1]}" );






/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/


Console.Write("Введите трехзначное число");
Console.WriteLine();
string? Number = Console.ReadLine();
while (Number.Length < 3)
    {
        Console.Write("Введите трехзначное число");
        Console.WriteLine();
        Number = Console.ReadLine();
    } 
Console.WriteLine ( $"Третья цифра трехначного числа: {Number [2]}" );



/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите цифру из предложенных вариантов: 1 2 3 4 5 6 6 7 , которая обозначает день недели");
Console.WriteLine();
int NumberDay = Convert.ToInt32(Console.ReadLine());
if (NumberDay == 6 | NumberDay == 7 )
    
        Console.WriteLine ("Это выходной");
    
else 
    
        Console.WriteLine ("Это будни");




