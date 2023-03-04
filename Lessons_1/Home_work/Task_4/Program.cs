// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число 1: ");
string a = Console.ReadLine()!;
int num1 = int.Parse(a);
Console.Write("Введите число 2: ");
string b = Console.ReadLine()!;
int num2 = int.Parse(b);
Console.Write("Введите число 3: ");
string c = Console.ReadLine()!;
int num3 = int.Parse(c);
int max = num1;

if (max > num2) max = num2;
else if (max > num3) max = num3;
Console.WriteLine(max);
