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
            Console.Write($"{numbers[i, j]}\t ");
        }
        Console.WriteLine("\n");
    }
    return 0;
}

(int, int) Dimensions(string input1, string input2)
{
    if (int.TryParse(input1, out int rows) && int.TryParse(input2, out int cols))
    {
        return (rows, cols);
    }
    return (0, 0);
}

int[,] AddArray(int[,] array1, int[,] array2)
{

    int row = array1.GetLength(0);
    int col = array1.GetLength(1);

    int[,] arraySum = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arraySum[i, j] = array1[i, j] + array2[i, j];
        }
    }
    return arraySum;
}

int[,] Array1;
int[,] Array2;
int[,] ArraySum;

string? inputRows;
string? inputCols;
string? input;

int rows, cols, dimension;

bool validate;
bool validateArray;

Console.WriteLine("Bienvenido a la sumadora de Matrices\n");

do
{
    validateArray = false;
    Console.WriteLine("Ingresa la cantidad de filas de la Matriz 1");
    inputRows = Console.ReadLine();
    do
    {
        validate = false;
        if (!string.IsNullOrEmpty(inputRows) && int.TryParse(inputRows, out dimension) && dimension > 0)
        {
            validate = true;
        }
        else
        {
            Console.WriteLine("Error: Ingrese un número entero mayor a 0.");
            inputRows = Console.ReadLine();
        }
    } while (validate == false);

    Console.WriteLine("Ingresa la cantidad de columnas de la Matriz 1");
    inputCols = Console.ReadLine();
    do
    {
        validate = false;
        if (!string.IsNullOrEmpty(inputCols) && int.TryParse(inputCols, out dimension) && dimension > 0)
        {
            validate = true;
        }
        else
        {
            Console.WriteLine("Error: Ingrese un número entero mayor a 0.");
            inputCols = Console.ReadLine();
        }
    } while (validate == false);


    (rows, cols) = Dimensions(inputRows!, inputCols!);

    Array1 = new int[rows, cols];
    Array1 = FillArray(Array1);

    Console.WriteLine("Ingresa la cantidad de filas de la Matriz 2");
    inputRows = Console.ReadLine();

    do
    {
        validate = false;
        if (!string.IsNullOrEmpty(inputRows) && int.TryParse(inputRows, out dimension) && dimension > 0)
        {
            validate = true;
        }
        else
        {
            Console.WriteLine("Error: Ingrese un número entero mayor a 0.");
            inputRows = Console.ReadLine();
        }
    } while (validate == false);

    Console.WriteLine("Ingresa la cantidad de columnas de la Matriz 2");
    inputCols = Console.ReadLine();

    do
    {
        validate = false;
        if (!string.IsNullOrEmpty(inputCols) && int.TryParse(inputCols, out dimension) && dimension > 0)
        {
            validate = true;
        }
        else
        {
            Console.WriteLine("Error: Ingrese un número entero mayor a 0.");
            inputCols = Console.ReadLine();
        }
    } while (validate == false);

    (rows, cols) = Dimensions(inputRows!, inputCols!);

    Array2 = new int[rows, cols];
    Array2 = FillArray(Array2);

    do
    {
        validate = false;

        Console.WriteLine("Desea sumar las matrices?: (s/n)");
        input = Console.ReadLine()?.ToLower();

        while (input != "s" && input != "n" && input != " ")
        {
            Console.WriteLine("Error: Ingrese's' o 'n'.");
            input = Console.ReadLine()?.ToLower();
        }

        if (input == "s")
        {
            if (Array1.GetLength(0) != Array2.GetLength(0) && Array1.GetLength(1) != Array2.GetLength(1))
            {
                Console.WriteLine("Error: Las matrices deben tener la misma cantidad de filas y columnas.");
                validate = true;
                validateArray = false;
                Console.WriteLine("\n Por favor, ingrese los dimensiones iguales.");
                continue;
            }
            else
            {
                Console.WriteLine("Array 1:");
                WriteArray(Array1);

                Console.WriteLine("\nArray 2:");
                WriteArray(Array2);

                Console.WriteLine("\nSuma de los Arrays:");
                ArraySum = AddArray(Array1, Array2);
                WriteArray(ArraySum);

                validate = true;
                validateArray = true;
            }
        }
        else
        {
            validate = true;
            Console.WriteLine("Array 1:");
            WriteArray(Array1);

            Console.WriteLine("\nArray 2:");
            WriteArray(Array2);

            validateArray = true;
        }

    } while (validate == false);
    
    Console.WriteLine("\nDesea crear otras matrices?: (s/n)");
    input = Console.ReadLine()?.ToLower();

    while (input != "s" && input != "n" && input != " ")
    {
        Console.WriteLine("Error: Ingrese's' o 'n'.");
        input = Console.ReadLine()?.ToLower();
    }

    if (input == "s")
    {
        validateArray= false;
    }
    else
    {
        validateArray=true;
    }
} while (validateArray == false);

Console.WriteLine("\nGracias por utilizar la sumadora de matrices.");
