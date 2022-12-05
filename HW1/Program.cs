﻿// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите число N  ");
int n=Convert.ToInt32(Console.ReadLine());

string PrintNum(int start, int end)
{
    if (start==end)
    {
     return end.ToString();   
    }
    return(start+" "+PrintNum(start-1,end));
}
Console.WriteLine(PrintNum(n,1));
