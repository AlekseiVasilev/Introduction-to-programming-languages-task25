// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("\n Задача 25");
Console.WriteLine("Введите числа А и B: "); // Приглашение ко вводу
double a = int.Parse(Console.ReadLine());
double b = int.Parse(Console.ReadLine());

void Degree(){
  double degree = Math.Pow(a, b);
  Console.Write($"число {a} в степени {b} равно {degree}");
}

Degree();