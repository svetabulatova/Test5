﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[]array=new double[10];
Random rand=new Random();
double res=0;
double max=array[0];
double min=array[0];
for (int i=0; i<array.Length; i++)
{
    array[i]=rand.Next (-100,100);
    if (array[i]>max)
    {
        max=array[i];
    }
    if (array[i]<min)
    {
        min=array[i];
    }
}
res=max-min;
Console.Write(string.Join(", ",array));
Console.WriteLine ($"=>{res}");


