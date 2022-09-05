int[,] RandomMatrix(int numRows, int numCols, int minValue, int maxValue) {
    int[,] result = new int[numRows, numCols];
    for (int i = 0; i < numRows; ++i) {
        for (int j = 0; j < numCols; ++j) {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); ++i) {
        for (int j = 0; j < matrix.GetLength(1) - 1; ++j) {
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine(matrix[i, matrix.GetLength(1) - 1]);
    }
}

void Shuffle(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); ++i) {
        for (int j = 0; j < matrix.GetLength(1) / 2; ++j) {
            int randUp = new Random().Next(matrix.GetLength(1) / 2, matrix.GetLength(1) - j - 1);
            int randDown = new Random().Next(j + 1, matrix.GetLength(1) / 2);
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, randUp];
            matrix[i, randUp] = temp;
            temp = matrix[i, matrix.GetLength(1) - 1 - j];
            matrix[i, matrix.GetLength(1) - 1 - j] = matrix[i, randDown];
            matrix[i, randDown] = temp;
        }
    }
}

try {
    Console.Write("Введите количество строчек матрицы: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов матрицы: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = RandomMatrix(a, b, 100, 1000);
    PrintMatrix(matrix);
    Shuffle(matrix);
    Console.WriteLine();
    PrintMatrix(matrix);
} catch {
    Console.WriteLine("Вы ввели что-то не то.");
}