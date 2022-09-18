// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// string SumRec(int N, int M)
// {
// if (N==M) return Convert.ToString(M);
// else return N +" , " + SumRec(N+1,M);
// }
// Console.WriteLine(SumRec(4,8));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumRec(int N, int M)
// {
// if (N==M+1) return 0;
// else return N + SumRec(N+1,M);
// }

// Console.WriteLine(SumRec(1,15));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int SumRec(int N, int M)
{
if (N==0) return M+1;
if (M==0) return SumRec(N-1,1);
else return SumRec(N-1,SumRec(N,M-1));
}
Console.WriteLine(SumRec(3,2));
     