//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

using System;

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());


int akk(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return akk(n - 1, 1);
    else return akk(n - 1, akk(n, m  - 1));
}

Console.WriteLine($"Функция Аккермана равна {akk(n, m)} ");
Console.WriteLine("Работа программы завершена. Нажмите любую клавишу для выхода...");
Console.ReadLine();