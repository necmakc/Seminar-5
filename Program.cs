// Задача 1:------------------------------------------------------------------------------------------------------------------------------------- 
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateArray(int length)
// {
//     int[] array = new int[length];
//     for (int index = 0; index < length; index++)
//     {
//         array[index] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int index = 0; index < array.Length; index++)
//         Console.Write(array[index] + " ");
//     Console.WriteLine();
// }

// int CalcCountEven(int[] array)
// {
//     int count = 0;
//     for (int index = 0; index < array.Length; index++)
//     {
//         if ((array[index] % 2) == 0)
//             count++;
//     }
//     return count;
// }

// Console.Write("Введите размер массива: ");
// int lengthArray = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(lengthArray);
// ShowArray(array);
// Console.WriteLine("Количество четных элементов равно " + CalcCountEven(array));

// Задача 2:------------------------------------------------------------------------------------------------------------------------------------- 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateArray(int length)
// {
//     int[] array = new int[length];
//     for (int index = 0; index < length; index++)
//     {
//         array[index] = new Random().Next(-99, 99);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int index = 0; index < array.Length; index++)
//         Console.Write(array[index] + " ");
//     Console.WriteLine();
// }

// int CalcSumOddPosition(int[] array)
// {
//     int sumOdd = 0;
//     for (int index = 1; index < array.Length; index += 2)
//         sumOdd += array[index];
//     return sumOdd;
// }

// Console.Write("Введите размер массива: ");
// int lengthArray = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(lengthArray);
// ShowArray(array);
// Console.WriteLine("Сумма элементов на нечетных позициях равна " + CalcSumOddPosition(array));

// Задача 3:------------------------------------------------------------------------------------------------------------------------------------- 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] CreateArray(int length)
// {
//     double[] array = new double[length];
//     for (int index = 0; index < length; index++)
//     {
//         // array[index] = Math.Round((new Random().NextDouble() * 100), 2);
//         Console.Write("Введите " + index + " элемент: ");
//         array[index] = Convert.ToDouble(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(double[] array)
// {
//     for (int index = 0; index < array.Length; index++)
//         Console.Write(array[index] + " ");
//     Console.WriteLine();
// }

// double CalcDifferenceMinMax(double[] array)
// {
//     double minElement = array[0];
//     double maxElement = array[0];
//     for (int index = 0; index < array.Length; index++)
//     {
//         if (array[index] < minElement)
//             minElement = array[index];
//         if (array[index] > maxElement)
//             maxElement = array[index];
//     }
//     double differenceMinMax = maxElement - minElement;
//     return differenceMinMax;
// }

// Console.Write("Введите размер массива: ");
// int lengthArray = Convert.ToInt32(Console.ReadLine());

// double[] array = CreateArray(lengthArray);
// ShowArray(array);
// double differenceMinMax = CalcDifferenceMinMax(array);
// Console.WriteLine("Разница между минимальным и максимальным элементов равна " + differenceMinMax);