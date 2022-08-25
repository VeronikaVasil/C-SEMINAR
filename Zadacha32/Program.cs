// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] testArray = {-2,-1,0,1,2};
for (int i = 0; i < testArray.Length; i++)
{
    // testArray[i] = testArray[i] * -1
    testArray[i] *= -1;
}
Console.WriteLine($"[{String.Join(",", testArray)}]");

