/*Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
нельзя использовать pow
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("введите число которое необходимо возвести в степень");
Console.WriteLine();
int numb = Convert.ToInt32(Console.ReadLine());
Console.Write("введите показатель степени");
Console.WriteLine();
int index = Convert.ToInt32(Console.ReadLine());
void exponent (int exponent)
    {
        if (index == 0)
        {
            exponent = 1;
            Console.WriteLine(exponent);
        }
        if (index == 1)
        {
            exponent = numb;
            Console.WriteLine(exponent);
        }
        for (int i = 2; i <= index; i++)
            {
                exponent = exponent * numb;
                
               
            }
    Console.WriteLine($" число {numb} возведенное в степень {index} будет {exponent} ");
    }

exponent (numb);

/*




Задача 27: Напишите матод, который принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

*/

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
void Summa(int numberN)
    {
        int result = 0;
        while (numberN > 0)
        {
            result += numberN % 10;
            numberN /= 10;            
        }
    Console.WriteLine(result);    
    }
Summa(numberN);  

/*


Задача 29: Напишите метод, который задаёт массив из 8 элементов (диапазон от 1 до 100) и выводит их на экран.
пример вывода
[1,4,5,3,1,2,3,9]
[4,45,53,31,14,25,63,19]

помним про задачу повышенной сложности

Написать метод, который генерирует массив 0 и 1 заданного количества N
3 -> 1 1 0
1 0 0
0 0 1

Написать метод, принимающий бинарное представление числа
и возвращающее десятиченое представление числа
1 1 0 0 -> 12
1 1 0 1 -> 13

Написать метод, принимающий десятиченое представление и основание СС в которую нужно это число перевести, 2<= основание СС<= 9
10,2 -> 1010
10,8 -> 12
6,6 -> 10
*/