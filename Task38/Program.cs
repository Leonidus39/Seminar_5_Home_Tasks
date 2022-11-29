/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

double[] NewRandomArray(int size, Double minNumber = 1.0, Double  maxNumber = 999.0)
        {
            Random rnd = new Random();
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                // 1.2 to 10.5
                array[i] = Math.Round(rnd.NextDouble() * (maxNumber - minNumber) + minNumber, 2);
            }
            return array;
        }

void ShowArray (double[]array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i<array.Length-1) Console.Write($"{array[i]}, ");    
        else Console.Write($"{array[i]}] -> ");     
    }
}
double Min(double[]array)
{
    double min = Double.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
     if(array[i]<min) min=array[i];   
    }
    return min;
}
double Max(double[]array)
{
    double max = Double.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
     if(array[i]>max) max=array[i];   
    }
    return max;
}
double [] array = NewRandomArray(4, 2.3, 78.5);
ShowArray(array);
Console.WriteLine($" {Math.Round(Max(array)-Min(array), 1)}");