// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101 3 -> 11
// 2 -> 10

string Convert(int num)
{
  string otvet = "";
  while (num > 0)
  {
    otvet = num % 2 + otvet; // Переводит число в двоичную систему;
    num = num / 2;
  }
  return otvet;
}
Console.WriteLine(Convert(12));