Console.Write("Wybierz kierunek: ");
string kierunek =  Console.ReadLine()!;

switch (kierunek)
{
    case "północ":
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Wyruszasz w stronę gór.");
        break;
    case "południe":
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Wyruszasz w stronę pustyni.");
        break;
    case "wschód":
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Wyruszasz w stronę lasu.");
        break;
    case "zachód":
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Wyruszasz w stronę morza.");
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Nieznany kierunek.");
        break;
}
Console.ResetColor();