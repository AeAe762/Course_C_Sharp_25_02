// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1




int TakeNum2(int num)
{
    Console.Write("Число равно = ");
    Console.WriteLine(num);
    int result1 = num / 10 % 10;
    return result1;
}

int result = TakeNum2(new Random().Next(100, 1000));
// int result = TakeNum2(int.Parse(Console.ReadLine()!));
Console.Write("Вторая цифра = ");
Console.WriteLine(result);