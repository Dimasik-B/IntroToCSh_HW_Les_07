int[,] array = GetArray(3, 4, -10, 10);
PrintArray(array);

Console.Write("Введитие интересующую строку: ");
int rowPosition = int.Parse(Console.ReadLine()!);
Console.Write("Введитие интересующий столбец: ");
int columnPosition = int.Parse(Console.ReadLine()!);

CheckPosition(rowPosition, columnPosition);

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

void CheckPosition (int rowPosition, int columnPosition){
    if (rowPosition >= 0 && rowPosition < array.GetLength(0)
        && columnPosition >= 0 && columnPosition < array.GetLength(1)){
            Console.WriteLine($"array[{rowPosition},{columnPosition}] = {array[rowPosition,columnPosition]}");
        }
        else Console.WriteLine($"Такой позиции нет: array[{rowPosition},{columnPosition}]");
}