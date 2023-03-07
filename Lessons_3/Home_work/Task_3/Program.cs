// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Kub(int num){int num_1 = 1; while (num_1 <= num) {Console.Write($"{Math.Pow(num_1, 3)} ");
num_1++; } Console.WriteLine();}
Kub(int.Parse(Console.ReadLine()!));