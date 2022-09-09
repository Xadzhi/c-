// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел происходит через Enter, останавливается при введении слова "stop"

// ПОЧЕМУ НЕ ЗАРАБОТАЛА ???

// double Count1(string args){
//     int count = 0;
//     while (args=="stop")
//     {
//         break;
//     }
//         int s = Convert.ToInt32(args);
//         if (s>0)
//                 {
//         count++;    
//         }
//         return count;
// }
// Console.Write(Count1(Console.ReadLine()));


int [] Array (string Ar){
    string [] Nums = Ar.Split(",");
    int[] res =new int [Nums.Length];
    for (int i = 0; i < res.Length; i++)
    {
        res[i]=Convert.ToInt32(Nums[i]);
    }
    return res;

}
int Array2(int [] arr){
    int count = 0;
    foreach (var item in arr)
    {
        if (item>0)
        {
            count++;
        }
    }
    return count;
}
System.Console.WriteLine("Введите числа после запятой");
int [] numbers = Array(Console.ReadLine());
System.Console.WriteLine(Array2(numbers));


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


// Console.WriteLine("Введите Число B1 ");
// double b1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите Число K1 ");
// double k1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите Число B2 ");
// double b2 = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите Число K2 ");
// double k2 = double.Parse(Console.ReadLine());

// double tochka1 = (b2-b1)/(k1-k2);
// System.Console.WriteLine($"Первая точка пересечения двух прямых" + tochka1);
// double tochka2 = k1 * tochka1 + b1;
// System.Console.WriteLine($"Вторая точка пересечения двух прямых" + tochka2);