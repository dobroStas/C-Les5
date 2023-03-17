// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] GetArray()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

int SumPositive(int [] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if((array[i] % 2) == 0) 
        sum += array[i];
    return sum;
}
int[] array = GetArray();
// Console.WriteLine(String.Join(" ", array));
// Console.WriteLine(SumPositive(array));
// ======================================================================================
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int Sum1Position(int [] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
        sum += array[i];
        
    return sum;
}

// Console.WriteLine(Sum1Position(array));



// ======================================================================================
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double [] doubleArr = {3, 7, 22, 2, 78};
double diffArray(double []array)
{
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i] < min)
            min = array[i];
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i] > max)
            max = array[i];
    double sum = max - min;
    return sum;
}
Console.WriteLine(String.Join(" ", doubleArr));
Console.Write(diffArray(doubleArr));