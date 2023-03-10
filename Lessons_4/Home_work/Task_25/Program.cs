// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Pow_number (int num_1, int num_2)
{
  int multi = 1;
  for (int i = 1; i <= num_2; i++) multi *= num_1;
return multi;
}
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
int result = Pow_number(A, B);
Console.WriteLine($"Число {A} в степени {B} равно {result}");
