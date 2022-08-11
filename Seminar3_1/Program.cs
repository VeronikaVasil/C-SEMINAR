// Задача 18: Напишите программу, которая по заданному  
// номеру четверти, показывает диапазон возможных  
// координат точек в этой четверти (x и y).  
Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(quarter); 
if (quarter == 1) Console.WriteLine("x > 0 && y > 0"); 
if (quarter == 2) Console.WriteLine("x < 0 && y > 0"); 
if (quarter == 3) Console.WriteLine("x < 0 && y < 0"); 
if (quarter == 4) Console.WriteLine("x > 0 && y < 0");

