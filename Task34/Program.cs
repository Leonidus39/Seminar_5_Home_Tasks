/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int [] NewRandomArray (int size, int min, int max)
{
    int[]array = new int [size];
    Random rnd = new Random ();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}
void ShowArray (int[]array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i<array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}
int EvenNumbers (int[]array)
{
    int digit = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0) digit+=1;
    }
    return digit;
}

int [] newRandomArray = NewRandomArray(4, 100, 999);
ShowArray(newRandomArray);

int evenNumbers = EvenNumbers(newRandomArray);
System.Console.WriteLine($" -> {evenNumbers}");
//ShowArray(evenNumbers);