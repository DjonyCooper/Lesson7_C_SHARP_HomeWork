// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Пример: m = 3, n = 4 
//     1   2    3    4
// 0| 0,5  7   -2  -0,2
// 1|  1 -3,3   8  -9,9
// 2|  8  7,8 -7,1   9
/*
double[,] CreateRandom2dArray() // Создание массива и обработка ошибок ввода(отсутствие числа или задание отрицательного значения для rows и columns)
{
    try
    {
        Console.Write("Input numbers of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input numbers of column: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input min value: ");  
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input max value: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());

        double[,] error = new double [0,0];
        double[,] newArray = new double [rows,columns];
        
        if(minValue > maxValue)
        {
            Console.Write($"Oh, sorry it is impossible to fulfill your request.\nSet by you min value: {minValue}, more than max value: {maxValue}.\nFix the error and try again.\n");
            return error;
        }
        else
        {
            for(int i = 0; i< rows;i++)
            {
                for(int j = 0; j < columns; j++ )
                {
                    newArray[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();            
                }
            } 
            return newArray;
        }
    }
    catch    
    {
        double[,] error = new double [0,0];
        Console.Write("To complete the task, we need all the values as well as the rows and columns values to be positive!\nFix the error and try again.");
        return error;
    }
}    

void Show2dArray(double[,] array)
{
    for(int i = 0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1); j++)
        {
            double num = array[i,j];
            string new_num = num.ToString("F1");
            Console.Write(new_num + " ");
        }
       Console.WriteLine();
    } 
    Console.WriteLine();  
}  

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет
/*
int[,] CreateRandom2dArray() // Создание массива и обработка ошибок ввода(отсутствие числа или задание отрицательного значения для rows и columns)
{
    try
    {
        Console.Write($"Отлично, теперь Вам необходимо задать размеры массива и то какими значениями его будем наполнять.\n");
        Console.Write("Задайте кол-во строк массива: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Задайте кол-во колонок массива: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.Write("Задайте минимальное число, от которого будем генерировать массив: ");  
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("Задайте максимальное число, до которого будем генерировать массив: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,] error = new int [0,0];
        int[,] newArray = new int [rows,columns];
        
        if(minValue > maxValue)
        {
            Console.Write($"Oh, sorry it is impossible to fulfill your request.\nSet by you min value: {minValue}, more than max value: {maxValue}.\nFix the error and try again.\n");
            return error;
        }
        else
        {
            for(int i = 0; i< rows;i++)
            {
                for(int j = 0; j < columns; j++ )
                {
                    newArray[i,j] = new Random().Next(minValue, maxValue + 1);           
                }
            } 
            return newArray;
        }
    }
    catch    
    {
        int[,] error = new int [0,0];
        Console.Write("To complete the task, we need all the values as well as the rows and columns values to be positive!\nFix the error and try again.");
        return error;
    }
}    

void Show2dArray(int[,] array)
{
    Console.Write("Сгенерирован случайный двумерный массив:\n");
    for(int i = 0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
       Console.WriteLine();
    } 
    Console.WriteLine();  
}  

int ReturnAnswer(int [,] array, int rowValue, int columnValue)
{
    int num = 0;
    for(int i = 0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1); j++)
        {
            if(i == rowValue-1 && j == columnValue-1)
            {
                num = array[rowValue-1, columnValue-1];
            }
        }
    }
    return num;  
}  

Console.Write("Здравствуйте, ув. пользователь!\n");
Console.Write("Для начала, задайте позиции элемента в двумерном массиве, на которых будем проверять наличие значения.\n");
Console.Write("Задайте номер строки: ");
int rowValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте номер столбца: ");
int columnValue = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
if(ReturnAnswer(myArray, rowValue, columnValue) != 0)
{
    Console.Write($"Число в {rowValue} строке и в {columnValue} колонке - {ReturnAnswer(myArray, rowValue, columnValue)}");
}
else
{
    Console.Write($"Числа, в {rowValue} строке и в {columnValue} колонке - нет");
}
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
//                                          1    4    7   2
//                                          5    9    2   3
//                                          8    4    2   4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
int[,] CreateRandom2dArray() // Создание массива и обработка ошибок ввода(отсутствие числа или задание отрицательного значения для rows и columns)
{
    try
    {
        Console.Write("Задайте кол-во строк массива: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Задайте кол-во колонок массива: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.Write("Задайте минимальное число, от которого будем генерировать массив: ");  
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("Задайте максимальное число, до которого будем генерировать массив: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,] error = new int [0,0];
        int[,] newArray = new int [rows,columns];
        
        if(minValue > maxValue)
        {
            Console.Write($"Oh, sorry it is impossible to fulfill your request.\nSet by you min value: {minValue}, more than max value: {maxValue}.\nFix the error and try again.\n");
            return error;
        }
        else
        {
            for(int i = 0; i< rows;i++)
            {
                for(int j = 0; j < columns; j++ )
                {
                    newArray[i,j] = new Random().Next(minValue, maxValue + 1);           
                }
            } 
            return newArray;
        }
    }
    catch    
    {
        int[,] error = new int [0,0];
        Console.Write("To complete the task, we need all the values as well as the rows and columns values to be positive!\nFix the error and try again.");
        return error;
    }
}    

void Show2dArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
       Console.WriteLine();
    } 
    Console.WriteLine();  
}  

string[] ReturnAnswerAverage(int [,] array)
{
    string[] arr = new string [array.GetLength(1)];

    double averange_value = 0;
    int count = 0;
    string averange_val = String.Empty;
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for(int i = 0; i<array.GetLength(1);i++)
    {
        averange_value = 0;
        count = 0;
            
        for(int j=0;j<array.GetLength(0); j++)
        {
            averange_value += array[j,i];
            count++;
        }
        if(i < i+1)
            averange_value = averange_value / count;
            averange_val = averange_value.ToString();
            arr[i] = averange_val + "; ";
             
    }
   return arr; 
}  

void ShowArray(string[] array)
{
    for(int i = 0; i<array.GetLength(0);i++)
    {
        Console.Write(array[i] + " ");
    } 
    Console.WriteLine();  
} 

int[,] ArrayNumUser = CreateRandom2dArray();
Show2dArray(ArrayNumUser);
string[] Arr = ReturnAnswerAverage(ArrayNumUser);
ShowArray(Arr);
*/