// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

 Console.WriteLine("Введите число: ");
 string a = Console.ReadLine()!;
 int num = int.Parse(a);
int b = 2;
while (b <= num)
{
    Console.Write(b+", ");
    b = b + 2;
}