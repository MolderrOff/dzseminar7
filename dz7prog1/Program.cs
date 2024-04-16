//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
//в промежутке от M до N. Использовать рекурсию, не использовать циклы.

using System;

void natureNum(int numM, int numN)
{
    if (numM - 1 == numN) return;
    natureNum(numM, numN - 1);
    Console.WriteLine($"{numN} ");
}


Console.WriteLine("Введите натуральное число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N, которое больше M");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= m) 
{
    Console.WriteLine($"Вывод всех натуральных чисел в промежутке от M до N, включая N: ");
    natureNum(m, n); 
} else
{
    Console.WriteLine("Вы ввели N < M. ");
};
Console.WriteLine("Программа завершена, для выхода нажмите любую клавишу...");
Console.ReadLine();