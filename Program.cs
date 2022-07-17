//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*double[,] GetTwoDimesionalArray(int rows, int columns) {
    Random rnd = new Random();
    double[,] arr = new double[rows, columns];

    for (var i = 0; i < rows; i++) {
        for (var i2 = 0; i2 < columns; i2++) {
            var nextD = rnd.NextDouble();
            var number = rnd.Next(-10, 10);
            var calcNumber = Math.Round(number + nextD, 2);
            
            arr[i, i2] = calcNumber;
        }
    }

    return arr;
}

Console.WriteLine("Write number of rows and columns to specify two dimensional array.");

Console.Write("Rows: ");
var inputRows = Console.ReadLine();

Console.Write("Columns: ");
var inputColumns = Console.ReadLine();

if (Int32.TryParse(inputRows, out var parsedInputRows) && Int32.TryParse(inputColumns, out var parsedInputColumns)) {
    if (parsedInputRows <= 0 || parsedInputColumns <= 0) {
        Console.WriteLine("Error: Row and column has to be positive numbers");
        return;
    }
    
    var array = GetTwoDimesionalArray(parsedInputRows, parsedInputColumns);

    for (var i = 0; i < parsedInputRows; i++) {
        for (var i2 = 0; i2 < parsedInputColumns; i2++) {
            Console.Write($"{array[i, i2]} ");
        }
        Console.WriteLine();
    }
}

else Console.WriteLine("Error: Input not valid");
*/

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*double[,] GetTwoDimesionalArray(int rows, int columns) {
    Random rnd = new Random();
    double[,] arr = new double[rows, columns];

    for (var i = 0; i < rows; i++) {
        for (var i2 = 0; i2 < columns; i2++) {
            arr[i, i2] = rnd.Next(-10, 10);
        }
    }

    return arr;
}

Console.WriteLine("Write number of rows and columns to specify two dimensional array.");

Console.Write("Rows: ");
var inputRows = Console.ReadLine();

Console.Write("Columns: ");
var inputColumns = Console.ReadLine();

if (Int32.TryParse(inputRows, out var parsedInputRows) && Int32.TryParse(inputColumns, out var parsedInputColumns)) {
    if (parsedInputRows <= 0 || parsedInputColumns <= 0) {
        Console.WriteLine("Error: Row and column has to be positive numbers");
        return;
    }
    
    var array = GetTwoDimesionalArray(parsedInputRows, parsedInputColumns);

    for (var i = 0; i < parsedInputRows; i++) {
        for (var i2 = 0; i2 < parsedInputColumns; i2++) {
            Console.Write($"{array[i, i2]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine($"Write the position you want to show. For example row 1, column 1 will show {array[0, 0]}");
    Console.Write("Row-position: ");
    var rowInput = Console.ReadLine();

    Console.Write("Column-position: ");
    var columnInput = Console.ReadLine();

    if (Int32.TryParse(rowInput, out var parsedRowInput) && Int32.TryParse(columnInput, out var parsedColumnInput)) {
        if (parsedRowInput <= 0 || parsedRowInput > parsedInputRows || parsedColumnInput <= 0 || parsedColumnInput > parsedInputColumns) Console.WriteLine("Error: Position does not exist");
        else {
            Console.WriteLine($"The number in this position is {array[parsedRowInput - 1, parsedColumnInput - 1]}");
        }
    }

    else Console.WriteLine("Error: Input not valid");
}

else Console.WriteLine("Error: Input not valid");
*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*double[,] GetTwoDimesionalArray(int rows, int columns) {
    Random rnd = new Random();
    double[,] arr = new double[rows, columns];

    for (var i = 0; i < rows; i++) {
        for (var i2 = 0; i2 < columns; i2++) {
            arr[i, i2] = rnd.Next(-10, 10);
        }
    }

    return arr;
}

Console.WriteLine("Write number of rows and columns to specify two dimensional array.");

Console.Write("Rows: ");
var inputRows = Console.ReadLine();

Console.Write("Columns: ");
var inputColumns = Console.ReadLine();

if (Int32.TryParse(inputRows, out var parsedInputRows) && Int32.TryParse(inputColumns, out var parsedInputColumns)) {
    if (parsedInputRows <= 0 || parsedInputColumns <= 0) {
        Console.WriteLine("Error: Row and column has to be positive numbers");
        return;
    }

    var array = GetTwoDimesionalArray(parsedInputRows, parsedInputColumns);

    for (var i = 0; i < parsedInputRows; i++) {
        for (var i2 = 0; i2 < parsedInputColumns; i2++) {
            Console.Write($"{array[i, i2]} ");
        }
        Console.WriteLine();
    }

    Console.Write("Arithmetic mean of each column: ");
    for (var i = 0; i < parsedInputColumns; i++) {
        double sum = 0;
        for (var i2 = 0; i2 < parsedInputRows; i2++) {
            sum += array[i2, i];
        }
        Console.Write($"{Math.Round(sum / parsedInputRows, 2)} ");
    }
}

else Console.WriteLine("Error: Input not valid");
*/