// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// int [] Bar(int min , int max , int size = 8 ){
//     int[] arr = new int [size]; 
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i]= new Random().Next(min,max);
//     }
//     return arr;
// }
// int Amount=0;
// var Are=Bar(99,999);
// foreach (var item in Are)
// {
//     if (item % 2==0)
//     {
//         Amount+=+1;
//     }
    
// }
// System.Console.WriteLine($"random array -> [{string.Join(" " ,Are)}]");
// System.Console.WriteLine(Amount);
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// int[] RandomArray(int size = 10)
// {
// int[] array = new int[size];
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(1, 99);
// }
// return array;
// }
// int FindAmount(int[] array)
// {
// int count = 0;
// for (int i = 1; i < array.Length; i++)
// {
// if (i % 2 != 0)
// {
// count+=array[i];
// }
// }
// return count;
// }
// int[] array = RandomArray(6);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine(FindAmount(array));
//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Double[] RandomArray(int size = 10)
{
Double[] array = new Double[size];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 99);
}
return array;
}
Double[] array = RandomArray();
Console.WriteLine($"[{string.Join(", ", array)}]");

Double max = array[0];
Double min = array[0];
 for (int i = 1; i < array.Length; i++)
 {
 if (array[i]>max)
 {
 max=array[i];
}
else if (array[i]<min)
{
min=array[i];
}
}
Double x = max - min;
Console.WriteLine($"Максимальный Элемент " + max);
Console.WriteLine($"Минимальный Элемент " + min);
Console.WriteLine($"Разницу между максимальным и минимальным " + x);