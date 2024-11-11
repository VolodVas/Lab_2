using System;

class MatrixProcessor
{
    private int[,] matrix;  // Матриця розмірності n x n
    private int size;       // Розмір матриці (n)

    public MatrixProcessor(int size)
    {
        this.size = size;
        matrix = new int[size, size];
        FillMatrix();
    }

    // Метод для заповнення матриці випадковими числами
    private void FillMatrix()
    {
        Random rand = new Random();
        Console.WriteLine("\nЗгенерована матриця:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = rand.Next(-100, 101); // Генерація числа з діапазону [-100; 100]
                Console.Write($"{matrix[i, j],5} ");
            }
            Console.WriteLine();
        }
    }

    // Метод для виведення головної діагоналі
    public void DisplayMainDiagonal()
    {
        Console.WriteLine("\nГоловна діагональ матриці:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(matrix[i, i] + " ");
        }
        Console.WriteLine();
    }

    // Метод для виведення бічної діагоналі
    public void DisplaySecondaryDiagonal()
    {
        Console.WriteLine("\nБічна діагональ матриці:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(matrix[i, size - i - 1] + " ");
        }
        Console.WriteLine();
    }

    // Метод для виведення елементів вище головної діагоналі, збільшених у 2 рази
    public void DisplayElementsAboveMainDiagonal()
    {
        Console.WriteLine("\nЕлементи вище головної діагоналі, збільшені в 2 рази:");
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                Console.Write($"{matrix[i, j] * 2,5} ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введіть розмір матриці (n x n): ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Некоректне значення! Будь ласка, введіть додатне ціле число.");
        }

        MatrixProcessor processor = new MatrixProcessor(n);

        // Виведення головної діагоналі
        processor.DisplayMainDiagonal();

        // Виведення бічної діагоналі
        processor.DisplaySecondaryDiagonal();

        // Виведення елементів вище головної діагоналі, збільшених у 2 рази
        processor.DisplayElementsAboveMainDiagonal();
    }
}
