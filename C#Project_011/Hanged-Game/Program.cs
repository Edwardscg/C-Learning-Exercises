static char[] WordSeparator(string word)
{
    char[] separator = word.ToCharArray();
    return separator;
}


Random rmd = new Random();
Console.OutputEncoding = System.Text.Encoding.UTF8;
string selectedWord;
char letter;

int numWord;
int advance = 0;
int stay = 0;
int body = 0;

string? input;

string[] Words = { "program", "study", "read", "videogame", "motorcycle", "engineer" };

do
{
    Console.WriteLine("Juego del ahorcado");

    numWord = rmd.Next(0, Words.Length);
    selectedWord = Words[numWord];

    //Console.WriteLine(selectedWord);

    char[] SelectedWord = WordSeparator(selectedWord);

    Console.WriteLine($"Adivina la palabra");

    for (int i = 0; i < SelectedWord.Length; i++)
    {
        do
        {
            do
            {
                input = Console.ReadLine()?.ToLower();
                if (!string.IsNullOrEmpty(input))
                {
                    letter = input[0];
                }
                else
                {
                    letter = ' ';
                    Console.WriteLine("Recuerda que debes ingresar una letra! \uD83D\uDE05");
                }
            } while (letter == ' ');

            if (letter == SelectedWord[i])
            {
                advance++;
                Console.WriteLine("\t \uD83D\uDE04 \uD83D\uDC4D");
                continue;
            }
            else
            {
                stay++;
                body++;
                Console.WriteLine("\t \uD83D\uDE1F \uD83D\uDC4E");
            }
        } while (letter != SelectedWord[i] && stay != 6);

        if (stay == 6)
        {
            Console.WriteLine("Perdiste! \uD83D\uDC94 \n  Vidas Agotadas!");
            break;
        }
        else if (advance == selectedWord.Length)
        {
            Console.WriteLine($"Ganaste! \uD83C\uDF89 \nLa palabra era: {selectedWord.ToUpper()}");
        }
        else { continue; }
    }

    Console.WriteLine("Desea volver a jugar? (s/n)");
    input = Console.ReadLine()?.ToLower();

    while (input != "s" && input != "n")
    {
        Console.WriteLine("Error: Ingreso inválido. Por favor, ingrese's' o 'n'.");
        input = Console.ReadLine()?.ToLower();
    }
} while (input != "n");

Console.WriteLine("Gracias por jugar! \uD83D\uDE4C");








