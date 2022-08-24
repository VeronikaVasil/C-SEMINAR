int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];
// ЛУЧШЕ выносить размер массива в отдельную переменную
for (int i = 0; i < size; i++) // size = array.Length
{
    array[i] = new Random().Next(11); // [0,10]
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");

// Способ №1 Создать новый мкссив и записать элементы в обратном порядке
int lastIndex = size - 1; // Индекс самого последнего элемента в массиве
int[] resultArray = new int[size];
for (int i = 0; i < size; i++) 
{
    resultArray[i] = array[lastIndex - i]; 
}
// array[1,2] -> array[2,1]   // result[i] = array[size-1-i]
// size = 2 , LastIndex = 1   // result[0] = array[LastIndex-i](i=0)
// LastIndex = size - 1       // result[0] = array[2-0]
// result[0] = array[size - 1]// i++
                              // result[1] = array[2-1]
Console.WriteLine($"Reverse array: [ {String.Join("; ", resultArray)} ]");
Console.ReadLine();
