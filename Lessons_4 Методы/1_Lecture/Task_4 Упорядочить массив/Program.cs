

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void Print_Array(int[] array) //Будет выводить массив
{
  int length = array.Length; // Считает размер массива
  for (int i = 0; i < length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}
void Selection_Sort(int [] array) //упорядочивает массив
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    int min_position = i; // присваивает переменной значение
    for (int j = i; j < array.Length; j++)
    {
      if (array[j] < array[min_position]) min_position = j;
    }
    int temporary = array[i];
    array[i] = array[min_position]; // меняем значение массива местами;
    array[min_position] = temporary; // меняем значение массива местами;
  }
}
Print_Array(arr);
Selection_Sort(arr);
Print_Array(arr);