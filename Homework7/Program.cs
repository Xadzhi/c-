// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// double [,] Array(int n , int m)
// {    var result = new double [n,m];
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//     result [i,j]= new Random().NextDouble();
    
// }
// }
// return result;
// }
// void Print(double[,] arr){for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++){
// System.Console.Write($"{arr[i,j]}");
// }System.Console.WriteLine();}
// }
// Print(Array(3,4));

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// вводим позиции по i и j -> если таких нет - выводим, что позиции не существует. Если есть - выводим элемент по этим индексам.

// int [,] Array(int n , int m)
// {    var result = new int [n,m];
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//     result [i,j]= new Random().Next(10);
    
// }
// }
// return result;
// }

// bool Coin(int[,] arr, int elements){
//     for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++){
// if (arr[i,j]==elements)
// {
//     return true;
// }
// }
// }
// return false;
// }
// var arr= (Array(3,4));
// System.Console.WriteLine(Coin(arr,9));

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] Array(int n , int m)
{    var result = new int [n,m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
    result [i,j]= new Random().Next(10);
    
}
}
return result;
}
double[] AArray(int [,] arr ){
    var result = new double [arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {double sum = 0;
    for (int j = 0; j < arr.GetLength(0); j++)
    {sum += arr[i,j];
        
    }
        result[i]=Math.Round(sum/arr.GetLength(0),2);
    }return result;
}
foreach (var item in AArray(Array(4,3)))
{
    System.Console.WriteLine(item);
}