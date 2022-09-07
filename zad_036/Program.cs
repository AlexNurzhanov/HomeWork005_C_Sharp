// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] GetArray(int size = 4)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}


int FindSumOddI(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
    {
    if (i % 2 > 0)
{
    sum = sum + array[i];
}
    }

    return sum;
}
int[] array = GetArray();
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(FindSumOddI(array));