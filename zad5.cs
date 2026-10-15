Console.WriteLine("Twój bohater jest w trakcie walki!");
int HP = 100;
Console.WriteLine($"Bohater ma {HP} punktów życia");
int obrazenia = 20;
Console.WriteLine($"Broń udziela {obrazenia} punktów obrażeń");
bool maMiksture = true;
Console.WriteLine(maMiksture ? "Mikstura jest w ekwipunku." : "Brak misktury.");
Console.Write("Wybierz jedną z opcji: \n 1 — atak, \n 2 — leczenie, \n 3 — ucieczka.\n  ");
int opcja = int.Parse(Console.ReadLine()!);
if(HP > 20)
{
    switch (opcja)
    {
        case 1:
            Console.WriteLine($"Udzielasz {obrazenia} punktów obrażeń wrogowi!");
            break;
        case 2:
            Console.WriteLine(maMiksture ? "Leczysz się miksturą" : "Brak misktury.");
            break;
        case 3:
            Console.WriteLine("Uciekasz z pola bitwy!");
            break;
        default:
            Console.WriteLine("Nieznana akcja.");
            break;    
    }
}
