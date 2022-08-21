// Написать программу, которая выводит случайное число из отрнезка
// [10,99] и показывает наибольшую цифру числа
// 78->8; 
// 12->2;
// 85->8;

int number = new Random().Next(10,100);// [10,99]
Console.WriteLine($"Рандомное число: {number}"); // Интерполяция - это способ вывести значение переменной и комментарий
Console.WriteLine("Рандомное число: " + number); // Конкатенация - это способ сложения строк
// camelCase
int firstDigit = number / 10; // разделить нацело на 10 (/)
// 78->8 =остаток деления на 10 (% 10)
int secondDigit = number % 10;

int maximum = firstDigit; // Пусть максимум это первое число
if (maximum < secondDigit) maximum = secondDigit;
Console.WriteLine($"Максимальная цифра в числе {number} - это {maximum}");

