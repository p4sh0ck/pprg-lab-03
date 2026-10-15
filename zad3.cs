Console.Write("Podaj swój wiek: ");
int wiek = int.Parse(Console.ReadLine());

if (wiek >= 65)
{
    Console.WriteLine("Jesteś seniorem.");
}
else if(wiek >= 18 && wiek < 65 ){
    Console.WriteLine("Jesteś osobą dorosłą.");
}
else if(wiek >= 13 && wiek < 18)
{
    Console.WriteLine("Jesteś nastolatkiem.");
}
else if(wiek >= 0 && wiek < 13)
{
    Console.WriteLine("Jesteś dzieckiem.");
}
else
{
    Console.WriteLine("Niepoprawny wiek!");
}