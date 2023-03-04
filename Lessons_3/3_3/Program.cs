// // 3. Напишите программу, которая принимает на вход число (N) 
//    и выдаёт таблицу квадратов чисел от 1 до N.

void Kvad(int num)
{
  int num_1 = 1;
  Console.Write(num);
  while (num >= num_1)
  {
    int result = num * num;
    Console.Write(result);
    num_1++;
  }
  Console.WriteLine();
}
int num = int.Parse(Console.ReadLine()!);
Kvad(num);

