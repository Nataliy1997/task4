// Напишите программу, которая принимает на вход три числа и выдаёт максимальное
// из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Clear();
Console.WriteLine("Введите первое число: ");
int A=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int B=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int C=int.Parse(Console.ReadLine()!);
int max=A;
if (max<B) max=B;
if (max<C) max=C;
Console.WriteLine($"Максимальное число: {max}");
