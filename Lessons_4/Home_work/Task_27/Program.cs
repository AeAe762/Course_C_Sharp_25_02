// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summa_num(int num)
{
  int summa = 0;
  for (int i = 0; i <= num; i++)
  {
    int last_num = num % 10;
    Console.Write($"Последняя цифра: {last_num} ");
    summa += last_num;
    Console.Write($"Сумма: {summa} ");
    Console.WriteLine();
    num /= 10;
    Console.Write($"Число: {num} ");
    
  }
  return summa;
}
int result = Summa_num(int.Parse(Console.ReadLine()!));
Console.WriteLine($"Сумма цифр числа равна {result}");

Console.WriteLine($"Вариант № 2 только функция записана в строчку");
int Summa_num_1(int num_1){int summa_1 = 0; for (int i = 0; i <= num_1; i++){
int last_num_1 = num_1 % 10; Console.Write($"Последняя цифра: {last_num_1} ");
summa_1 += last_num_1; Console.Write($"Сумма: {summa_1} "); Console.WriteLine();
num_1 /= 10; Console.Write($"Число: {num_1} ");} return summa_1;}
int result_1 = Summa_num_1(int.Parse(Console.ReadLine()!));
Console.WriteLine($"Сумма цифр числа равна {result_1}");
