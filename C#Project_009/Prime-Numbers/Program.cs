static int PrimeNumbers(int num1, int num2)
{
    bool printed = false;

    for (int i = num1; i <= num2; i++)
    {
        if (i == 1)
        {
            continue;
        }
        if (i == 2 || i == 3 || i == 5 || i == 7)
        {
            Console.WriteLine(i + " Es primo");
            printed = true;
        }
        if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
        {
            continue;
        }
        else
        {
            Console.WriteLine(i + " Es primo");
            printed = true;
        }
    }
    if (!printed)
    { }
    return 0;
}



Console.WriteLine("Bienvenido al mostrador de números primos");
Console.WriteLine("Ingrese el rango de los números primos a mostrar");

Console.Write("Ingrese el rango mínimo: ");
string? rangoMin = Console.ReadLine();
Console.Write("\n");

Console.Write("Ingrese el rango máximo: ");
string? rangoMax = Console.ReadLine();
Console.Write("\n");

bool option = false;

do
{
    string? input;
    int min, max;
    int isPrime;

    bool valid1 = int.TryParse(rangoMin, out min);
    bool valid2 = int.TryParse(rangoMax, out max);

    if (valid1 && valid2)
    {
        isPrime = PrimeNumbers(min, max);
    }
    else
    {
        Console.WriteLine("Error: Los valores ingresados no son numeros enteros.");

        Console.Write("Ingrese el rango mínimo: ");
        rangoMin = Console.ReadLine();
        Console.Write("\n");

        Console.Write("Ingrese el rango máximo: ");
        rangoMax = Console.ReadLine();
        Console.Write("\n");
        continue;
    }

    Console.Write("Desea verificar otro rango? (s/n): ");
    input = Console.ReadLine()?.ToLower();
    while (input != "s" && input != "n")
    {
        Console.WriteLine("Error: Ingreso inválido. Por favor, ingrese's' o 'n'.");
        input = Console.ReadLine()?.ToLower();
    }
    if (input == "s")
    {
        Console.Write("Ingrese el rango mínimo: ");
        rangoMin = Console.ReadLine();
        Console.Write("\n");

        Console.Write("Ingrese el rango máximo: ");
        rangoMax = Console.ReadLine();
        Console.Write("\n");
        continue;
    }
    else
    {
        option = true;
    }

} while (option == false);

Console.WriteLine("\nGracias por utilizar el mostrador de números primos.");



