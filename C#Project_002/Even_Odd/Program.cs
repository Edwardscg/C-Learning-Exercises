Console.WriteLine("Ingresa el número a validar");

string? number = Console.ReadLine();
int num;

bool valid = int.TryParse(number, out num);

if (valid)
{
    if (num % 2 == 0)
    {
        Console.WriteLine("El número es par.");
    }
    else 
    {
        Console.WriteLine("El número es impar.");
    }
}
else 
{
    Console.WriteLine("No has ingresado un número válido");
}

