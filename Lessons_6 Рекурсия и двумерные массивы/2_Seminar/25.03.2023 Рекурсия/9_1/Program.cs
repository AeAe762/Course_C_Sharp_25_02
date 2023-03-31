// // 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.

// void ValuesSet(int M, int N)
// {
//     if (N < M) return; // Функция работает пока нижняя граница меньше верхней
//     ValuesSet(M, N - 1);
//     Console.Write($"{N} ");
// }

// int num = int.Parse(Console.ReadLine()!);
// int num_1 = int.Parse(Console.ReadLine()!);
// ValuesSet(num_1, num);

void ValuesSet(int M, int N)
{
    if (N < M) return;
    ValuesSet(M , N- 1);
    Console.Write($"{N} ");
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
ValuesSet(num1, num2);