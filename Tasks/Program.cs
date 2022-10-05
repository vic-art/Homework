// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное
// из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a, b, c;

Console.WriteLine("Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.WriteLine("Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);

Console.WriteLine("Введите третье число: ");
int.TryParse(Console.ReadLine()!, out c);

if (a > b)
    if (a > c) 
    {
        Console.WriteLine($"{a}");
    }
    else
    {
        Console.WriteLine($"{c}");
    }
else if (b > c)
{
    Console.WriteLine($"{b}");
}
else
{
    Console.WriteLine($"{c}");
}

