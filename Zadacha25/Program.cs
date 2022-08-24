//Число А в степень В циклом for
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int step = numberA;

for(int i = 1; i < numberB; i++)
{
step = step * numberA;
}

Console.WriteLine($"{numberA} ^ {numberB} = {+ step}");

