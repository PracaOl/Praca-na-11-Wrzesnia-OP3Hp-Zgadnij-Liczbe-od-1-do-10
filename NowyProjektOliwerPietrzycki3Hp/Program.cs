// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// OP3Hp
double y;

Random rnd = new Random();
int x = rnd.Next(1, 10);

do
{
	Console.WriteLine("Podaj liczbę od 1 do 10:");
	string liczba = Console.ReadLine();
	y = double.Parse(liczba);


	if (y < x)
	{
		Console.WriteLine("Podana liczba jest mniejsza od wylosowanej liczby.");
	}

	if (y > x)
	{
		Console.WriteLine("Podana liczba jest wieksza od wylosowanej liczby.");
	}

} while (y != x);

if (y == x)
{
	Console.WriteLine("Zgadles! Jest to:" + x);
}