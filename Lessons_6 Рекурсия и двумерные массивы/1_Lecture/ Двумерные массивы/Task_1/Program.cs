// String [,] Table = new string [2,5]; // Создали двумерный массив состоящий из 2 строк
// // и 5 столбцов
// Table[1,3] = "Word"; // Указали, что во 2 строке 4 столбце должно записано слово Word
// Table[0,4] = "Hello"; // Указали, что 1 строке 5 столбце должно быть Hello
// for (int i = 0; i < 2; i ++) // цикл который будет считать строки
// {
//   for (int j = 0; j < 5; j ++) // цикл который будет считать столбцы
//   {
//     Console.Write($"({Table[i, j]} ||) "); // выводит строку и столбец
//   }
// Console.WriteLine(); // разделяет строки
// }

// ----------------------------------------------------

void PrintArray(int[,] Matr) // Метод который выводит таблицу
{
  for (int i = 0; i < Matr.GetLength(0); i++) // для строк; GetLength(0) определяет количество строк
  {
    for (int j = 0; j < Matr.GetLength(1); j++) // для столбцов; GetLength(1) определяет количество столбов 
    {
      Console.Write($"{Matr[i, j]} ");
    }
    Console.WriteLine();
  }
}

void FillArray (int [,] Matr) // Метод который будет заполнять нашу таблицу
{
  for (int i = 0; i < Matr.GetLength(0); i++)
  {
    for (int j = 0; j < Matr.GetLength(1); j++)
    {
      Matr [i,j] = new Random().Next(1, 10); //заполняет таблицу числами от 1 до 10
    }
  }
}
int[,] Matrix = new int[3, 4];
// PrintArray(Matrix); // Выводит(инициализирует) 1 функция с 000
FillArray(Matrix); //  Вызывает 2 функцию с рандомными числами
Console.WriteLine();
PrintArray(Matrix); // Выводит 2 функцию с заполненными числами