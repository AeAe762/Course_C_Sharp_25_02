// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void week(string week_day)
{
  if (week_day == "1") Console.WriteLine("No");
  else if (week_day == "2") Console.WriteLine("No");
  else if (week_day == "3") Console.WriteLine("No");
  else if (week_day == "4") Console.WriteLine("No");
  else if (week_day == "5") Console.WriteLine("No");
  else if (week_day == "6") Console.WriteLine("Yes");
  else if (week_day == "7") Console.WriteLine("Yes");
}
week(Console.ReadLine()!);