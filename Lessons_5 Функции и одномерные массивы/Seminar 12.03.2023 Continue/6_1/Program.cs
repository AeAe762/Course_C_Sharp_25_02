// Напишите программу, которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.

void Triangle (int num_1, int num_2, int num_3)
{
  if (num_1 < num_2 + num_3 && num_2 < num_1 + num_3 && num_3 < num_1 + num_2)
    Console.WriteLine ($"Yes");
  else Console.WriteLine($"No");
}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
Triangle(a, b, c);
