// Задача 38: Задайте массив int чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

 int [] array = new int [5];
 Console.Write("[");

 for(int i = 0; i < array.Length; i++)
 {
     array[i] = new Random().Next(1,100);
     Console.Write(array[i]+" ");
 }
 Console.Write("]");

 int min = array.Min();
 int max = array.Max();

 Console.Write($"Max = {max}, Min = {min}");
 Console.Write($" Разница между Max и Min = {max - min}");
