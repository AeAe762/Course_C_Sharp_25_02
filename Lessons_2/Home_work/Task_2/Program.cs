// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int TakeNum(int num)
{
  Console.WriteLine("Введите число: ");
  Console.WriteLine(num);
  int num1 = num % 10; // Последняя цифра
  int num2 = num % 1000 / 100;// первая цифра
  int result = num2 * 10 + num1;
  return result;
}
//int otvet = TakeNum(int.Parse(Console.ReadLine()!));
int otvet = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(otvet);