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

double [,] CreateArrayMatrixReal (int m, int n, int x, int y){ // m - row; n - column;  x - min element; y - max+1 element
    double [,] ar = new double [m,n];
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            ar [i,j] = Convert.ToDouble(new Random().Next(x,y)/1000.0);
        }
    }
    return ar;
}

void PrintArrayMatrix (int [,] ar){
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++){
            Console.Write($"{ar[i,j]} | ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine();
}

void PrintArrayMatrixReal (double [,] ar){
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++){
            Console.Write($"{ar[i,j]} | ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine();
}

void SearchNumberMatrixIndexs (double [,] ar, int m, int n){
    if(ar.GetLength(0) >= m && ar.GetLength(1) >= n ){
        Console.WriteLine($"Элемет с индексом {m} {n}: {ar[m,n]}");
    }
    else Console.WriteLine($"Элемет с индексом {m} {n} НЕ СУЩЕСТВУЕТ");
}


/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.WriteLine("Задача 47 ");

Console.WriteLine("Введите размерность массива ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double [,] array47 = CreateArrayMatrixReal(m, n, -10000, 10000);

PrintArrayMatrixReal(array47);



/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
Console.WriteLine("Задача 50 ");

Console.WriteLine("Введите позицию элемента из массива задачи 47 ");
int m_elementposition = Convert.ToInt32(Console.ReadLine());
int n_elementposition = Convert.ToInt32(Console.ReadLine());
SearchNumberMatrixIndexs (array47, m_elementposition, n_elementposition);


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Задача 52 ");

Console.WriteLine("Введите размерность массива ");
int m1 = Convert.ToInt32(Console.ReadLine());
int n1 = Convert.ToInt32(Console.ReadLine());
int [,] array52 = CreateArrayMatrix(m1, n1, 0, 10);

PrintArrayMatrix(array52);

Console.Write($"Среднее арифметическое столбцов: ");
double average;
for (int i = 0; i < array52.GetLength(1); i++) 
    {
        average = 0;
        for (int j = 0; j < array52.GetLength(0); j++)
        {
            average += array52[j,i];
        }
        Console.Write($"{average/array52.GetLength(0)} "); 
    }
Console.WriteLine();

/*Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и найдите сумму элементов главной диогонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/
Console.WriteLine("Задача 51");
Console.WriteLine("Введите размерность массива ");
int m51 = Convert.ToInt32(Console.ReadLine());
int n51 = Convert.ToInt32(Console.ReadLine());
int [,] array51 = CreateArrayMatrix(m51, n51, 0, 10); // m - row; n - column;  x - min element; y - max+1 element
int sum51 = 0;
for (int i = 0; i < array51.GetLength(0) && i < array51.GetLength(1); i++)
    {
        sum51 += array51[i,i];
    }
PrintArrayMatrix(array51);
Console.WriteLine($"сумма элементов главной диагонали = {sum51}");