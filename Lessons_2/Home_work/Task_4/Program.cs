// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


//string s_a = Console.ReadLine()!;
void week(int num)
{
 if (num == 1)
 {
   Console.WriteLine("Нет");
 }
 else if (num == 2)
 {
   Console.WriteLine("Нет");
 }
 else if (num == 3)
 {
   Console.WriteLine("Нет");
 }
 else if (num == 4)
 {
   Console.WriteLine("Нет");
 }
 else if (num == 5)
 {
   Console.WriteLine("Нет");
 }
 else if (num == 6)
 {
   Console.WriteLine("Да");
 }
 else if (num == 7)
 {
   Console.WriteLine("Да");
 }
 else Console.WriteLine("Ошибка");
}
week(int.Parse(Console.ReadLine()!));

