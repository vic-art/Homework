// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int N;
int i = 2;

Console.WriteLine("Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

while (i <= N)
{
    Console.Write($"{i} ");
    i+=2;
    }


