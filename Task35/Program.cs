// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


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
int[] arr = FillArrayWithRandomNumber(123, 0, 500);
Console.WriteLine(string.Join(", ", arr));


// Второй метод - поиск количества четных чисел в массиве
int NumberIntervalInArray(int[] array)
{
    int Number = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 100 & array[i] > 9)
        {
            Number = Number + 1;
        }
    }
    return Number;
}


// Запуск второго метода
int res = NumberIntervalInArray(arr);
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] = {res}"); 