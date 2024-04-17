//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
using System;


void printCreateMas(int[] col, int mode, int i = 0)
{
    if (i >= col.Length) return;
    if (mode == 1) 
    { 
        col[i] = new Random().Next(0, 101);
        Console.Write($"{col[i]} ");

    }
    printCreateMas(col, mode, i + 1);
    if (mode == 2)
    {
        Console.Write($"{col[i]} ");
    }
}

Console.WriteLine("Введите размер одномерного массива: ");
string n = Console.ReadLine();
int numericValue;
bool isNumber = int.TryParse(n, out numericValue);
int n1 = 11;
if (isNumber == true)
{
    if (numericValue > 0)
    {
        n1 = numericValue;

    }
    else
    {
            Console.WriteLine($"Введённое значение < 1, установлено значение размера массива по умолчанию N = {n1}"); 
    }
}
else 
{
    Console.WriteLine($"Введённое значение не является числом, установлено значение размера массива по умолчанию N = {n1}");

};
int[] mas = new int[n1];
Console.WriteLine("Исходный массив: ");
printCreateMas(mas, 1);
Console.WriteLine();
Console.WriteLine("Вывод элементов массива с конца: ");
printCreateMas(mas, 2);
Console.WriteLine();
Console.WriteLine("Работа программы завершена. Для выхода нажмите любую клавишу...");
Console.ReadLine();