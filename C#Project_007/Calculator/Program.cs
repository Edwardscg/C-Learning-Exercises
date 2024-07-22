static int Sum(int num1, int num2)
{
    return num1 + num2;
}

static int Subtraction(int num1, int num2)
{
    return num1 - num2;
}

static int Multiplication(int num1, int num2)
{
    return num1 * num2;
}

static double Division(float num1, int num2)
{
    return num1 / num2;
}

static int Power(int num1, int num2)
{
    if (num2 == 0)
    {
        return 1;
    }
    else
    {
        int result = 1;
        for (int i = 0; i < num2; i++)
        {
            result *= num1;
        }
        return result;

        //Or

        //return num1 * Power(num1, num2-1);
    }
}

static int Num1DataEntry(int num1)
{
    Console.WriteLine("Ingresa el primer número");
    num1 = Convert.ToInt32(Console.ReadLine());
    return num1;
}

static int Num2DataEntry(int num2)
{
    Console.WriteLine("Ingresa el segundo número");
    num2 = Convert.ToInt32(Console.ReadLine());
    return num2;
}

static int Num2Validation(int num)
{
    if (num == 0)
    {
        do
        {
            Console.WriteLine("No se puede dividir por cero, ingrese un número diferente de cero");
            num = Convert.ToInt32(Console.ReadLine());
        } while (num == 0);
        return num;
    }
    else
    {
        return num;
    }

}

Console.WriteLine("Bienvenido a mi calculadora");
Console.WriteLine("Ingrese la operación a realizar:(+, -, *, /, **) ó '0' para salir.");
string? operation = Console.ReadLine();

do
{
    int number1 = 0;
    int number2 = 0;

    switch (operation)
    {
        case "+":
            number1 = Num1DataEntry(number1);
            number2 = Num2DataEntry(number2);
            Console.WriteLine($"Resultado de la operación: {Sum(number1, number2)}");
            break;
        case "-":
            number1 = Num1DataEntry(number1);
            number2 = Num2DataEntry(number2);
            Console.WriteLine($"Resultado de la operación: {Subtraction(number1, number2)}");
            break;
        case "*":
            number1 = Num1DataEntry(number1);
            number2 = Num2DataEntry(number2);
            Console.WriteLine($"Resultado de la operación: {Multiplication(number1, number2)}");
            break;
        case "/":
            number1 = Num1DataEntry(number1);
            number2 = Num2DataEntry(number2);
            number2 = Num2Validation(number2);
            Console.WriteLine($"Resultado de la operación: {Division(number1, number2)}");
            break;
        case "**":
            number1 = Num1DataEntry(number1);
            number2 = Num2DataEntry(number2);
            Console.WriteLine($"Resultado de la operación: {Power(number1, number2)}");
            break;
        default:
            Console.WriteLine("Operación no válida");
            break;

    }
    Console.WriteLine("Ingrese la operación a realizar:(+, -, *, /, **) ó '0' para salir.");
    operation = Console.ReadLine();
} while (operation != "0");

Console.WriteLine("I hope i've helped.");
