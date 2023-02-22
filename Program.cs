//task1  Показать двумерный массив размером m×n заполненный вещественными числами
/*

double[,] NewArr(int row, int col, int low, int high)
{
    double[,] array = new double[row, col];
    
    Random random = new Random();

    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int z = 0; z < array.GetLength(1); z++)

        array[a,z] = Math.Round(random.NextDouble() * (high-low), 2);
    }

    return array;
}

int InputInt(string message)
{
    Console.Write(message);

    return int.Parse(Console.ReadLine());
}


void OutputToArray(double[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int z = 0; z < array.GetLength(1); z++)

        Console.Write($"{array[a,z]} \t");
        Console.WriteLine();
    }
}


int row = InputInt("Please,enter the number of rows: ");
int col = InputInt("Please,enter the number of columns: ");
int low = InputInt("Please,enter the lower bound of the random fill: ");
int high = InputInt("Please,enter the higher bound of the random fill: ");


double[,] array = NewArr(row, col, low, high);

OutputToArray(array);

*/





//task2  Задать двумерный массив следующим правилом: Aₘₙ = m+n
/*

double[,] NewRowsAndColumns(int rows, int columns)
{
    double[,] array = new double[rows, columns];

    Random random = new Random();

    for (int a = 0; a < array.GetLength(0); a++)
    {
    for (int b = 0; b < array.GetLength(1); b++)

    array[a,b] = a + b;  
    }

    return array;
}

int InputInt(string communication)
{
    Console.Write(communication);

    return int.Parse(Console.ReadLine());
}

void OtputToArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        Console.Write($"{array[i,j]} \t");
        Console.WriteLine();
    }
}


int row = InputInt("Please,enter the number of rows: ");
int col = InputInt("Please,enter the number of columns: ");

double[,] array = NewRowsAndColumns(row, col);

OtputToArray(array);

*/







//task3  В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

/*

int[,] NewArray(int row, int col, int low, int high)
{
    int[,] array = new int[row, col];

    Random random = new Random();

    for (int a = 0; a < array.GetLength(0); a++)
    {
       for (int b = 0; b < array.GetLength(1); b++)
     
       array[a,b] = random.Next(low, high);

    }

    return array;
}

int InputInt(string communication)
{
    Console.Write(communication);
    return int.Parse(Console.ReadLine());
}

void PrintToArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)

        Console.Write($"{array[a,b]}\t");
        Console.WriteLine();
    }
}

int[,] Changing(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)

        if (a%2==0 && b%2==0) array[a,b] *= array[a,b];
    }
    
    return array;
}


int row = InputInt("Please,enterthe number of rows: ");
int col = InputInt("Please,enter the number of columns: ");
int low = InputInt("Please,enter the lower bound of the random fill: ");
int high = InputInt("Please,enter the higher bound of the random fill: ");

int[,] array = NewArray(row, col, low, high);


PrintToArray(array);
Console.WriteLine();
PrintToArray(Changing(array));

*/






//task4 Написать программу, которая обменивает элементы первой строки и последней строки

/*

int[,] CreateArray(int rows, int col, int low, int high)
{
    int[,] array = new int[rows, col];
    Random random = new Random();
    
    for (int a = 0; a < array.GetLength(0); a++)
    {
    for (int b = 0; b < array.GetLength(1); b++)

    array[a,b] = random.Next(low, high);
    }

    return array;
}

int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintToArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)

        Console.Write($"{array[a,b]}\t");
        Console.WriteLine();
    }
}

int[,] ReplaceRows(int[,] array)
{
    int temp = 0;

    for (int a = 0; a < array.GetLength(1); a++)
    {
       temp = array[0,a];
       array[0,a] = array[array.GetLength(0)-1, a];
       array[array.GetLength(0)-1, a] = temp;
    }

    return array;
}


int row = InputInt("Please,enter the number of rows: ");
int col = InputInt("Please,enter the number of columns: ");
int low = InputInt("Please,enter the lower bound of the random fill: ");
int hight = InputInt("Please,enter the higher bound of the random fill: ");

int[,] array = CreateArray(row, col, low, hight);

PrintToArray(array);
Console.WriteLine();
PrintToArray(ReplaceRows(array));

*/