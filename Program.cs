// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("\n Задача 25");
Console.WriteLine("Введите числа А и B: "); // Приглашение ко вводу
double a = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty)); // int columns = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty)); - алгоритм избавления от ошибки null
// int num = int.Parse(Console.ReadLine());
double b = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty)); // int columns = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty)); - алгоритм избавления от ошибки null
// int num = int.Parse(Console.ReadLine());

void Degree(){
  double degree = Math.Pow(a, b);
  Console.Write($"число {a} в степени {b} равно {degree}");
}
Degree();