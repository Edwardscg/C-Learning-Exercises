static int[] SortArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = 0; j < numbers.Length - 1; j++)
        {
            int temp = 0;
            if (numbers[j] > numbers[j + 1])
            {
                temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }
    return numbers;
}

static int[] ArrayGenerator(int[] numbers, int num)
{
    for (int i = 0; i < num; i++)
    {
        bool validation = false;
        do
        {
            Console.WriteLine($"Valor {i + 1}: ");
            string? number = Console.ReadLine();
            int numInt;

            bool valid = int.TryParse(number, out numInt);
            if (valid)
            {
                numbers[i] = numInt;
                validation = true;
            }
            else
            {
                Console.WriteLine("Error al ingresar el número. Ingrese un número entero.");
                continue;
            }

        } while (validation == false);
    }
    return numbers;
}

static int ShowArray(int[] numbers)
{
    bool temp = false;
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
        temp = true;
    }
    if (!temp)
    { }
    return 0;
}

Console.WriteLine("Ordenador de Matriz");

Console.WriteLine("Ingrese el tamaño de la matriz:");
string? arraySize = Console.ReadLine();

bool validation = false;
string? option;

do
{
    int size;
    bool valid = int.TryParse(arraySize, out size);

    int[] Numbers = new int[size];

    if (valid)
    {
        ArrayGenerator(Numbers, size);
        Console.WriteLine("\nMatriz original:");
        ShowArray(Numbers);
        validation = true;
    }
    else
    {
        Console.WriteLine("Error al ingresar el tamaño de la matriz. Ingrese un número entero.");
        arraySize = Console.ReadLine();
        continue;
    }

    Console.WriteLine("\n\nQuiere ordenar los elementos de sus arreglo?: (s/n)");
    option = Console.ReadLine()?.ToLower();
    while (option!= "s" && option!= "n")
    {
        Console.WriteLine("Opción inválida. Ingrese's' para ordenar o 'n' para cancelar.");
        option = Console.ReadLine()?.ToLower();
    }
    if (option == "s")
    {
        Console.WriteLine("\nOrdenado ascendentemente:");
        SortArray(Numbers);
        ShowArray(Numbers);
        validation = true;
    }
    else
    {
        Console.WriteLine("No se ha ordenado los elementos.");
        validation = true;
    }
} while (validation == false);

Console.WriteLine("\n\nEspero haberte ayudado.");
