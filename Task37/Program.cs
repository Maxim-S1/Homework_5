// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


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

//Второй метод - поиск минимального числа в массиве
int SearchMinNumber(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        
        if(array[i] < min)
        min = array[i];
    }
    return min;
}

// Запуск второго метода 
int Min = SearchMinNumber(arr);
Console.WriteLine($"Минимальное число в массиве = {Min}");

//Третий метод - поиск максимального числа в массиве
int SearchMaxNumber(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        
        if(array[i] > max)
        max = array[i];
    }
    return max;
}

// Запуск третьего метода 
int Max = SearchMaxNumber(arr);
Console.WriteLine($"Максимальное число в массиве = {Max}");

Console.WriteLine($"Сумма максимального и минимального числа массива = {Max + Min}");