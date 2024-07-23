static int Factorial(int num)
{
    if (num == 0)
    {
        return 1;
    }
    else
    {
        return num * Factorial(num - 1);
    }
}

Console.WriteLine("Calculadora de Factorial");
Console.WriteLine("Ingrese el número a calcular: ");
string? input = Console.ReadLine();

do
{
    int number;
    int result = 0;

    bool valid = int.TryParse(input, out number);

    if (valid)
    {
        result = Factorial(number);
        Console.WriteLine($"El factorial de {number} es: {result}");
    }
    else
    {
        Console.WriteLine("Ingreso invalido, ingresa un número entero.");
        input = Console.ReadLine();
        continue;
    }
    Console.WriteLine("Desea calcular el factorial de otro número? (s/n)");
    input = Console.ReadLine()?.ToLower();
    if (input == "n")
    {
        break;
    }
    else
    {
        while (input != "s")
        {
            Console.WriteLine("Ingreso no valido, escoja una opción: (s/n)");
            input = Console.ReadLine()?.ToLower();
        }

        Console.WriteLine("Ingrese el número a calcular: ");
        input = Console.ReadLine();
    }
} while (input != "N" || input != "n");

Console.WriteLine("Espero haberte ayudado.");
