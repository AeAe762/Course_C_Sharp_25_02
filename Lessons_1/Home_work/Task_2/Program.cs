// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число 1: ");
string a = Console.ReadLine()!;
int num1 = int.Parse(a);
Console.Write("Введите число 2: ");
string b = Console.ReadLine()!;
int num2 = int.Parse(b);

if (num1 > num2)
{
  Console.Write("Ответ: ");
  Console.WriteLine(num1);
}
else
{
  Console.Write("Ответ: ");
  Console.WriteLine(num2);
}