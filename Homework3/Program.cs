/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/

Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine());

    int[] AA = new int [5] ;
    for (int i=0; A>0; i++)
    {
        AA[i]=A % 10;
        A/= 10;
    }
   if (AA [0]==AA[4]&&AA[1] ==AA[3])
   {
    System.Console.WriteLine($"Данное число является палиндромом ");
    
  }
else
     {
        System.Console.WriteLine($"Данное число не является палиндромом ");
        
   } 


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//double Bga( int x1 , int y1 , int z1 , int x2 , int y2 , int z2 )
//{
//return Math.Round(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)),2);
//}
//System.Console.WriteLine(Bga(3,6,8,2,1,-7));


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//int A = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= A ; i++)
//{
//    System.Console.Write( " " + i*i*i + " ");
//}

