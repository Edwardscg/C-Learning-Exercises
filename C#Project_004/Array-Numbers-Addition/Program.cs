int[] numbers = new int[5];

for(int i=0; i<numbers.Length; i++)
{
    Console.Write("Enter an integer number: ");

    string? num = Console.ReadLine();
    int number;

    bool valid = int.TryParse(num, out number);

    if(valid)
    {
        numbers[i] = number;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        i--;
    }
}

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

Console.WriteLine("Sum of the numbers in the array: " + sum);