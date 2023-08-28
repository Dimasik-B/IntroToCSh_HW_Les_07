Console.Write("Введитие количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введитие количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

double[,] GetArray(int rows, int columns, int minValue, int maxValue){
    double[,] result = new double[rows,columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            result[i,j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return result;
}

void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($" {Math.Round(array[i,j], 1)} ");
        }
        Console.WriteLine();
    }
}