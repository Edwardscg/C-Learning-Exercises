Console.WriteLine("Ingresa una frase: ");
string? chain = Console.ReadLine();
if (chain != null)
{
    string reverseText = InvertirFrase(chain);
    Console.WriteLine("Frase invertida");
    Console.WriteLine(reverseText);
}
else
{
    Console.WriteLine("No has ingresado una frase válida");
}

static string InvertirFrase(string text)
{
    char[] caracteres = text.ToCharArray();
    Array.Reverse(caracteres);
    return new string(caracteres);
}