Random rmd = new Random();

Console.WriteLine("Bienvenido al juego");
Console.WriteLine("1. Jugar a adivina el número");
Console.WriteLine("0. Salir");
int option = Convert.ToInt32(Console.ReadLine());

do
{
    switch (option)
    {
        case 1:

            int randomNum = rmd.Next(1, 11);
            Console.WriteLine("Adivina un número entre 0 y 10:");
            int number = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (number < randomNum)
                {
                    Console.WriteLine("Tu número es menor, prueba otro más alto.");
                    number = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Tu número es mayor, prueba otro más bajo.");
                    number = Convert.ToInt32(Console.ReadLine());
                }
            } while (number != randomNum);
            if (number == randomNum)
            {
                Console.WriteLine("Has ganado!");
            }
            Console.WriteLine("");
            break;
        case 0:
            Console.WriteLine("Gracias por jugar!");
            break;
    }

    Console.WriteLine("1. Jugar a adivina el número");
    Console.WriteLine("0. Salir");
    option = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Gracias por jugar!");
} while (option != 0);

//Version whitout switch

// int randomNum = rmd.Next(0, 11);
// Console.WriteLine("Adivina un número entre 0 y 10:");
// int number = Convert.ToInt32(Console.ReadLine());

// do
// {
//     if (number < randomNum)
//     {
//         Console.WriteLine("Tu número es menor, prueba otro más alto.");
//         number = Convert.ToInt32(Console.ReadLine());
//     }
//     else
//     {
//         Console.WriteLine("Tu número es mayor, prueba otro más bajo.");
//         number = Convert.ToInt32(Console.ReadLine());
//     }

// } while (number != randomNum);

// if (number == randomNum)
// {
//     Console.WriteLine("Has ganado!");
// }