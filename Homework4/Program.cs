/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите Число А ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Число Б ");
int B = int.Parse(Console.ReadLine());
int C = 1;
for (int i = 0; i <B; i++)
{
    C*=A;
}
System.Console.WriteLine(C);

*/
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.WriteLine("Введите Число А ");
// int A = int.Parse(Console.ReadLine());
// double sum = 0;
//         while  (A>0)
//     { 
//         sum = sum + A % 10 ;
//         A = A / 10 ;
       
//     }
//     System.Console.WriteLine(sum);
//System.Console.WriteLine(i);
//foreach (var item in Ax(521))
//{
 //System.Console.WriteLine(item);   
//}


/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

double [] A ()
{
double [] Ar = new double [8] ;
for (int i = 0; i < 8; i++)
{
    Ar[i]=new Random().Next();
}
return Ar;
} 

System.Console.Write($"[{string.Join(", ", A())}]");

Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
(ЕСЛИ ВВОДИТЬ МАССИВ ВРУЧНУЮ)

Console.WriteLine("Введите массив ");
int A = int.Parse(Console.ReadLine());

    int[] AA = new int [8] ;
    for (int i=7; A>0; i=i-1)
    {
        AA[i]=A % 10;
        A/= 10;
    }

     Console.Write("[{0}]", string.Join(", ", AA));*/