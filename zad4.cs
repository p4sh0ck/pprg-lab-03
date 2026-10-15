int hp = 55;
string stan = hp > 0 ? "żyje" : "nie żyje";

Console.WriteLine($"Bohater {stan}.");
bool maKlucz = true;
bool znaHaslo = true;

bool mozeWejsc = (hp > 0 && (maKlucz || znaHaslo));
if (mozeWejsc == true)
{
    Console.WriteLine("Bohater może wejść do lochu");
}
else
{
    Console.WriteLine("Bohater nie może wejść do lochu");
}

