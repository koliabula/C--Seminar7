int [,] CreateArrayMatrix (int m, int n, int x, int y){ // m - row; n - column;  x - min element; y - max+1 element
    int [,] ar = new int [m,n];
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            ar [i,j] = new Random().Next(x, y);
        }
    }
    return ar;
}

void PrintArrayMatrix (int[,] ar){
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++){
            Console.Write($"{ar[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MaxElementArray (int[] ar){
    int max = ar[0];
    for (int i = 0; i < ar.Length; i++)
    {
        if (max < ar[i]){
            max = ar[i];
        }
    }
    return max;
}

int MinElementArray (int[] ar){
    int min = ar[0];
    for (int i = 0; i < ar.Length; i++)
    {
        if (min > ar[i]){
            min = ar[i];
        }
    }
    return min;
}



/*Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/
/*
Console.WriteLine("Введите размерность массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = CreateArrayMatrix(m, n, -100, 100);
PrintArrayMatrix(array);
*/


/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/
/*
Console.WriteLine("Введите размерность массива ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] array48 = new int [m,n];

for (int i = 0; i < array48.GetLength(0); i++)
    {
        for (int j = 0; j < array48.GetLength(1); j++)
        {
            array48 [i,j] = i+j;
        }
    }

PrintArrayMatrix(array48);
*/



/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4*/
/*
Console.WriteLine("Введите размерность массива ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = CreateArrayMatrix(m, n, 0, 10);

PrintArrayMatrix(array);

for (int i = 2; i < array.GetLength(0); i+=2)
{
    for (int j = 2; j < array.GetLength(1); j+=2)
    {
        array[i,j] *= array[i,j];
    }
}
PrintArrayMatrix(array);
*/




/*Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и найдите сумму элементов главной диогонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/
Console.WriteLine("Введите размерность массива ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] array51 = CreateArrayMatrix(m, n, 0, 10); // m - row; n - column;  x - min element; y - max+1 element
int sum = 0;
for (int i = 0; i < array51.GetLength(0) && i < array51.GetLength(1); i++)
    {
        sum += array51[i,i];
    }
PrintArrayMatrix(array51);
Console.WriteLine($"сумма элементов главной диагонали = {sum}");

