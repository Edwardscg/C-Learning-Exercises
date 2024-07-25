int[] FractionAddition(int[] frac1, int[] frac2)
{
    int[] Result = new int[2];

    if (frac1[1] == frac2[1])
    {
        Result[0] = frac1[0] + frac2[0];
        Result[1] = frac1[1];
        return Result;
    }
    else
    {
        Result[0] = (frac1[0] * frac2[1]) + (frac1[1] * frac2[0]);
        Result[1] = frac1[1] * frac2[1];
        return Result;
    }
}

int[] FractionSubstract(int[] frac1, int[] frac2)
{
    int[] Result = new int[2];

    if (frac1[1] == frac2[1])
    {
        Result[0] = frac1[0] - frac2[0];
        Result[1] = frac1[1];
        return Result;
    }
    else
    {
        Result[0] = (frac1[0] * frac2[1]) - (frac1[1] * frac2[0]);
        Result[1] = frac1[1] * frac2[1];
        return Result;
    }
}

int[] FractionMultiply(int[] frac1, int[] frac2)
{
    int[] Result = new int[2];

    Result[0] = frac1[0] * frac2[0];
    Result[1] = frac1[1] * frac2[1];
    return Result;
}

int[] FractionDivision(int[] frac1, int[] frac2)
{
    int[] Result = new int[2];

    Result[0] = frac1[0] * frac2[1];
    Result[1] = frac1[1] * frac2[0];
    return Result;
}

int[] Fraction1 = new int[2];
int[] Fraction2 = new int[2];
int[] SumFraction = new int[2];

int num = 0;
string? input;
bool validate;
char operation = ' ';

for (int i = 0; i < Fraction1.Length; i++)
{
    if (i == 0)
    {
        Console.WriteLine("Ingrese el numerador de la fracción 1: ");
        input = Console.ReadLine();
        do
        {
            validate = false;
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out num))
            {
                Fraction1[i] = num;
                validate = true;
            }
            else
            {
                Console.WriteLine("Error al ingresar el número. Ingrese un número entero.");
                input = Console.ReadLine();
                validate = false;
            }
        } while (validate == false);
    }
    else
    {
        Console.WriteLine("Ingrese el denominador de la fracción 1: ");
        input = Console.ReadLine();

        do
        {
            validate = false;
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out num) && num > 0)
            {
                Fraction1[i] = num;
                validate = true;
            }
            else
            {
                Console.WriteLine("Error al ingresar el número. Ingrese un número entero.");
                input = Console.ReadLine();
                validate = false;
            }
        } while (validate == false);
    }
}

for (int i = 0; i < Fraction2.Length; i++)
{
    if (i == 0)
    {
        Console.WriteLine("Ingrese el numerador de la fracción 2: ");
        input = Console.ReadLine();

        do
        {
            validate = false;
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out num))
            {
                Fraction2[i] = num;
                validate = true;
            }
            else
            {
                Console.WriteLine("Error al ingresar el número. Ingrese un número entero.");
                input = Console.ReadLine();
                validate = false;
            }
        } while (validate == false);
    }
    else
    {
        Console.WriteLine("Ingrese el denominador de la fracción 2: ");
        input = Console.ReadLine();

        do
        {
            validate = false;
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out num) && num > 0)
            {
                Fraction2[i] = num;
                validate = true;
            }
            else
            {
                Console.WriteLine("Error al ingresar el número. Ingrese un número entero.");
                input = Console.ReadLine();
                validate = false;
            }
        } while (validate == false);
    }
}

validate = false;

do
{
    Console.WriteLine("Ingrese la operación que quiere realizar: +, -, *, /");
    input = Console.ReadLine();

    do
    {
        do
        {
            if (!string.IsNullOrEmpty(input))
            {
                operation = input[0];
                validate = true;
            }
            else
            {
                Console.WriteLine("Error al ingresar la operación. Ingrese una operación válida.");
                input = Console.ReadLine();
            }
        }while(validate==false);

        validate = false;

        switch (operation)
        {
            case '+':
                SumFraction = FractionAddition(Fraction1, Fraction2);

                Console.WriteLine("\nResultado de la multiplicación de lafracción:");

                Console.WriteLine(SumFraction[0]);
                Console.WriteLine("_");
                Console.WriteLine(SumFraction[1]);

                validate = true;
                break;
            case '-':
                SumFraction = FractionSubstract(Fraction1, Fraction2);

                Console.WriteLine("\nResultado de la resta de lafracción:");

                Console.WriteLine(SumFraction[0]);
                Console.WriteLine("_");
                Console.WriteLine(SumFraction[1]);

                validate = true;
                break;
            case '*':
                SumFraction = FractionMultiply(Fraction1, Fraction2);

                Console.WriteLine("\nResultado de la multiplicación de lafracción:");

                Console.WriteLine(SumFraction[0]);
                Console.WriteLine("_");
                Console.WriteLine(SumFraction[1]);

                validate = true;
                break;
            case '/':
                SumFraction = FractionDivision(Fraction1, Fraction2);

                Console.WriteLine("\nResultado de la división de lafracción:");

                Console.WriteLine(SumFraction[0]);
                Console.WriteLine("_");
                Console.WriteLine(SumFraction[1]);

                validate = true;
                break;
            default:
                Console.WriteLine("Opción ínvalida, seleccione una de estas opciones: +, -, *, /");
                input = Console.ReadLine();
                break;
        }
    } while (validate == false);

    do
    {
        Console.WriteLine("\n¿Desea realizar otra operación? (s/n)");
        input = Console.ReadLine()?.ToLower();

        while(input != "s" && input != "n")
        {
            Console.WriteLine("Error: Ingreso inválido. Por favor, ingrese's' o 'n'.");
            input = Console.ReadLine()?.ToLower();
        }

        if (input == "s")
        {
            validate = false;
        }
        else
        {

            validate = true;
        }
    } while (input != "s" && input != "n");
} while (validate == false);

Console.WriteLine("Gracias por usar la calculadora de fracciones!");


