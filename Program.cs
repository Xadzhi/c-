﻿/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine());
Console.Write($"Вторая цифра {(( A % 100 )-( A % 10 )) / 10 }");

Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/

Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine());
if ( A > 99 )
{
Console.Write($"Третья цифра = {((A % 1000)-(A % 100))/100}");
}
else
{
    Console.Write(" нету третьей цифры");
}

/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool A ( int n ) { return n==1|n==2|n==3|n==4|n==5; }
bool flag = A ( 1 );
Console.Write( A ( 4 ) );*/
