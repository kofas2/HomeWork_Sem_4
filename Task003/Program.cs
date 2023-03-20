﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void ArrayGenerate(int []array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }

}

void ArrayPrint(int []array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length -1]}");
    Console.Write("]");
}

int [] array = new int[8];
ArrayGenerate(array);
ArrayPrint(array);