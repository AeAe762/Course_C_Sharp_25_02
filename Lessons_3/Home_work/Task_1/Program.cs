// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Вариант 1");
Console.Write("Введите число: ");
void Task(int num)
{
  if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10) Console.WriteLine($"Число {num} является палиндромом");
  else Console.WriteLine($"Число {num} не является палиндромом");
  return;
}
Task(int.Parse(Console.ReadLine()!));



Console.WriteLine("Вариант 2");
Console.Write("Введите число: ");
void Task_2(string num)
{
  if (num[0] == num[4] && num[1] == num[3]) Console.WriteLine($"Число {num} является палиндромом");
  else Console.WriteLine($"Число {num} не является палиндромом");
  return;
}
Task_2(Console.ReadLine()!);

