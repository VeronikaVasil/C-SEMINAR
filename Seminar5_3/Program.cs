int[] testArray = { -2, -1, 0, 1, 2, 15, 22, 99, 100 };

int count = 0; // 0 чисел лежат в диапазоне

for (int i = 0; i < testArray.Length; i++) // testArray.Length - длина массива
{
    if (testArray[i] >= 10 && testArray[i] <= 99) count++; // count = count + 1 
}

System.Console.WriteLine(count);

