// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


Console.Write("Введите 1 число : ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число : ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 3 число : ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2)
{
  Console.WriteLine("Yes");
}
else Console.WriteLine("No");
