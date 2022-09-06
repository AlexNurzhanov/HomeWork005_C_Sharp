// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int[] GetArray(int minValue, int maxValue, int size = 4)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
var array = GetArray(100,1000);
int count = 0;
foreach (var item in array)
{
        if (item%2 == 0){
        count ++; 
    }
}
System.Console.WriteLine($"[{string.Join(' ', array)}]");
System.Console.WriteLine(count);