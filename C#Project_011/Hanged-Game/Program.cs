static char[] WordSeparator(string word)
{
    char[] separator = word.ToCharArray();
    return separator;
}


Random rmd = new Random();
string selectedWord;
char letter;

int numWord;
int advance = 0;
int stay = 0;
int body=0;

string[] Words = { "program", "study", "read", "videogame", "motorcycle", "engineer" };

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
        letter = Convert.ToChar(Console.ReadLine()?[0]);
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
        Console.WriteLine("Perdiste! \n  Vidas Agotadas!");
        break;
    }
    else if (advance == selectedWord.Length)
    {
        Console.WriteLine($"Ganaste! \nLa palabra era: {selectedWord.ToUpper()}");
    }
    else { continue; }
}







