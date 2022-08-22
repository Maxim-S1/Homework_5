// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Первый метод - задание рандомного массива
int[] FillArrayWithRandomNumber(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, rightRange+1);
    }
    return array;
}


// Запуск первого метода
int[] arr = FillArrayWithRandomNumber(4, 100, 1000);
Console.WriteLine(string.Join(", ", arr));


// Второй метод - поиск количества четных чисел в массиве
int IsEvenNumberInArray(int[] array)
{
    int Number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            Number = Number + 1;
        }
    }
    return Number;
}


// Запуск второго метода
int res = IsEvenNumberInArray(arr);
Console.WriteLine($"Количество четных чисел = {res}"); 

