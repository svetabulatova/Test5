﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[]array=new int [25];
Random rand=new Random();
int sum=0;
for (int i=0; i<array.Length; i++)
{
    array[i]=rand.Next (-100,100);
}
for (int i=1;i<array.Length;i+=2)
{
    sum=sum+array[i];
}
Console.Write(string.Join(", ",array));
Console.WriteLine ($"=>{sum}");

