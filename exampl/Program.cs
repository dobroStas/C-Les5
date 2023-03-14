// __Таблицы!!__

// string [,] table = new string[2, 5];

// String.Empty
// table[1, 2] = "Слово";

// for(int i = 0; i < 2; i++)
// {
//     for(int j = 0; j < 5; j++)
//     {
//         Console.WriteLine($"-{table[i, j]}-");
//     }
// }

// ====================================================

// int [,] matr = new int[3, 4];
// for(int i = 0; i < 3; i++)
// {
//     for(int j = 0; j < 4; j++)
//     {
//         Console.Write($"{matr[i, j]} ");
//     }
// Console.WriteLine();    // переход на новую строку
// }

// ===================================================

// В циклах, методах
// int [,] matr = new int[3, 4];
// for(int i = 0; i < matr.GetLength(0); i++)
// {
           
//     for(int j = 0; j < matr.GetLength(1); j++)
//     {
//         Console.Write($"{matr[i, j]} ");
//     }
// Console.WriteLine();    // переход на новую строку
// }

// =============================================

// Метод__

void PrintArray(int [,] matr)
{

    for(int i = 0; i < matr.GetLength(0); i++)
    {    
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();    // переход на новую строку
    }
}
// int [,] matrix = new int[3, 4];

// PrintArray(matrix);

// ====================================================

// Сдучайные числа__

void FillArray(int [,] matr)
{

    for(int i = 0; i < matr.GetLength(0); i++)
    {    
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 2);
        }
    Console.WriteLine();    // переход на новую строку
    }
}
// int [,] matrix = new int[3, 4];

// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// ===================================================

// Расскраска единиц__

void PrintImages(int [,] image)
{

    for(int i = 0; i < image.GetLength(0); i++)
    {    
        for(int j = 0; j < image.GetLength(1); j++)
        {
            // Console.Write($"{image[i, j]} ");
            if (image[i, j] == 0) Console.Write($"-");
            else Console.Write($"+");
        }
    Console.WriteLine();    // переход на новую строку
    }
}


// int [,] pic = new int[25, 25];  // метод с картинкой 
// PrintImages(pic);

// ========================

//  Закраска рисунка__
// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }

// PrintImages(pic);
// FillImage(13, 13);
// PrintImages(pic);

// ================================

// Приглашение на ввод данных

int Promt()
{
    Console.WriteLine("Введите число:");
    return Convert.ToInt32(Console.ReadLine());
}

// ==========================================

// Факториал__

double Factorial(int n)
{
    // 0! = 1
    // 1! = 1
    if (n ==1) return 1;
    else return n * Factorial(n - 1);
}


// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// ===================================================

// f(1) = 1
// f(2) = 1
// f(n) = f(n - 1) + f(n - 2)

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}


// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Fibonacci(i)}");
// }


