// Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Write("Введите число обозначающее длину одномерного массива: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число обозначающее минимальное значение случайного числа из промежутка: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число обозначающее максимальное значение случайного числа из промежутка: ");
int C = Convert.ToInt32(Console.ReadLine());

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
int[] arr = FillArrayWithRandomNumber(A, B, C);
Console.WriteLine(string.Join(", ", arr));

// Второй метод - поиск суммы нечетных чисел в массиве
int SumUneverNumberInArray(int[] array)
{
    int Sum = 0;
    for(int i = 0; i < array.Length; i += 2)
    {
        Sum += array[i];
    }
    return Sum;
}


// Запуск второго метода
int res = SumUneverNumberInArray(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях массива = {res}"); 