static int[,] FillArray(int[,] numbers)
{
    string? input;
    int number;

    int row = numbers.GetLength(0);
    int column = numbers.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.WriteLine($"Position: ({i},{j})");
            input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                numbers[i, j] = number;
            }
            else
            {
                Console.WriteLine("Error: Ingrese un número entero.");
                j--;
            }

        }
    }
    return numbers;
}

static int WriteArray(int[,] numbers)
{
    
    int row = numbers.GetLength(0);
    int column = numbers.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{numbers[i, j]} ");
        }
        Console.WriteLine("");
    }
    return 0;
}

int[,] Array2;
int[,] Array1;

string? inputRows;
string? inputCols;

int rows;
int cols;

bool validate;

Console.WriteLine("Bienvenido a la sumadora de Matrices\n");



Console.WriteLine("Ingresa la cantidad de filas de la Matriz 1");
inputRows = Console.ReadLine();
do
{
    validate = false;
    if (!string.IsNullOrEmpty(inputRows))
    {
        validate = true;
    }
    else
    {
        inputRows = Console.ReadLine();
    }
} while (validate == false);

Console.WriteLine("Ingresa la cantidad de columnas de la Matriz 1");
inputCols = Console.ReadLine();
do
{
    validate = false;
    if (!string.IsNullOrEmpty(inputCols))
    {
        validate = true;
    }
    else
    {
        inputCols = Console.ReadLine();
    }
} while (validate == false);

if (int.TryParse(inputRows, out rows) && int.TryParse(inputCols, out cols))
{
    Array1 = new int[rows, cols];
    Array1 = FillArray(Array1);

    Console.WriteLine("Array 1:");
    WriteArray(Array1);
}

Console.WriteLine("Ingresa la cantidad de filas de la Matriz 2");
inputRows = Console.ReadLine();

do
{
    validate = false;
    if (!string.IsNullOrEmpty(inputRows))
    {
        validate = true;
    }
    else
    {
        inputRows = Console.ReadLine();
    }
} while (validate == false);

Console.WriteLine("Ingresa la cantidad de columnas de la Matriz 2");
inputCols = Console.ReadLine();

do
{
    validate = false;
    if (!string.IsNullOrEmpty(inputCols))
    {
        validate = true;
    }
    else
    {
        inputCols = Console.ReadLine();
    }
} while (validate == false);

if (int.TryParse(inputRows, out rows) && int.TryParse(inputCols, out cols))
{
    Array2 = new int[rows, cols];
    Array2 = FillArray(Array2);

    Console.WriteLine("\nArray 2:");
    WriteArray(Array2);
}


