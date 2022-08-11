Console.Write("Введите координату Х  точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y  точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х  точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y  точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1-x2,2) + (Math.Pow(y1-y2,2)));
Console.WriteLine($"Расстояние: {Math.Round(result,3)}");





