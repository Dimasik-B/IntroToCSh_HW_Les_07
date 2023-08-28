int[,] array = GetArray(3, 4, 1, 9);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"{String.Join(", ", ColumnsMean(array))}");



int[,] GetArray(int rows, int columns, int minValue, int maxValue){
    int[,] result = new int[rows,columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[] ColumnsMean (int[,] array){
    double[] result = new double[array.GetLength(1)];
    double sum = 0;
    for(int i = 0; i < array.GetLength(1); i++){
        for(int j = 0; j < array.GetLength(0); j++){
            sum += array[j,i];
        }
    result[i] = Math.Round(sum / array.GetLength(0), 1);
    sum = 0;
    }
    return result;
}