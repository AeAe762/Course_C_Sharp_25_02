double Factorial (int num)
{
  if (num == 1) return 1;
  else return num * Factorial(num - 1);
}
for (int i = 1; i < 40; i++)
{
  Console.WriteLine($"{i}! = {Factorial(i)}");
}
