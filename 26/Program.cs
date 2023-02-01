/*Задача 19

Напишите метод, который принимает на вход шестизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
строки использовать нельзя
*/


Console.Write("введите пятизначное число");
Console.WriteLine();
int number = Convert.ToInt32(Console.ReadLine());
void verific (int number)
{
    if (number >9999 && number < 100000 )
        {
            int a = number / 10000 % 10;
            int b = number / 1000 % 10;
            int c = number / 100 % 10;
            int d = number / 10 % 10;
            int e = number % 10;
            if (a == e && b == d)
                {
                Console.WriteLine ($" {number} число полиндром ");
                }
            else
                Console.WriteLine ($" {number} число не полиндром ");
        }
    else
        Console.WriteLine ("Число не пятизначное");

}

verific (number);


/*
Задача 21

Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/



double coordinates = 0;
void Distance (double coordinates)
    {
        Console.Write("введите координаты точки А ");
        Console.Write("по оси абсцисс");
        Console.WriteLine();
        double coordinates_AOX = Convert.ToInt32(Console.ReadLine());
        Console.Write (coordinates_AOX);
        Console.Write("по оси ординат");
        Console.WriteLine();
        double coordinates_AOY = Convert.ToInt32(Console.ReadLine());
        Console.Write("по оси аппликат");
        Console.WriteLine();
        double coordinates_AOZ = Convert.ToInt32(Console.ReadLine());

        Console.Write("введите координаты точки B ");
        Console.Write("по оси абсцисс");
        Console.WriteLine();
        double coordinates_BOX = Convert.ToInt32(Console.ReadLine());
        Console.Write("по оси ординат");
        Console.WriteLine();
        double coordinates_BOY = Convert.ToInt32(Console.ReadLine());
        Console.Write("по оси аппликат");
        Console.WriteLine();
        double coordinates_BOZ = Convert.ToInt32(Console.ReadLine());

        coordinates = Math.Sqrt((Math.Pow(coordinates_BOX - coordinates_AOX, 2)) 
                              + (Math.Pow(coordinates_BOY - coordinates_AOY, 2)) 
                              + (Math.Pow(coordinates_BOZ - coordinates_AOZ, 2)));

        Console.WriteLine(coordinates);
    }
Distance(coordinates);


/*
Задача 23

Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

* В большинстве задач методов будет несколько
*/

Console.Write("введите число");
Console.WriteLine();
double numb = Convert.ToInt32(Console.ReadLine());
void verification (double numb)
{
    for (double i = 1; i <= numb; i++)
    {
        double value = Math.Pow ( i, 3); 
        Console.WriteLine ($" {i} - {value}");
    }
}

verification (numb);


