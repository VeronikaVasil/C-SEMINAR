int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());
if (A + B > C && A + C > B && B + C > A)
{
    Console.WriteLine($"Треугольник со сторонами {A} , {B} , {C} существует ");
}
else Console.WriteLine($"Треугольник со сторонами {A} , {B} , {C} НЕ существует ");
