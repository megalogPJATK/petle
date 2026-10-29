// zadanie 1

/*

int[] zlotoWTurach = { 5, 12, 0, 8 ,15};

int tura = 1;

int zloto10 = 0;

double razem = 0;

for (int i = 0; i < zlotoWTurach.Length; i++)
{
    Console.WriteLine($"Tura {tura}: {zlotoWTurach[i]}");
    tura++;

    razem += zlotoWTurach[i];

    if (zlotoWTurach[i] > 10)
    {
        zloto10++;
    }
}

double srednia = razem / zlotoWTurach.Length;

Console.WriteLine($"Łącznie: {razem}");
Console.WriteLine($"Średnio na ture: {srednia}");
Console.WriteLine($"Tury z wynikiem co najmniej 10: {zloto10}");
Console.Write($"Od końca: {zlotoWTurach[4]}, {zlotoWTurach[3]}, {zlotoWTurach[2]}, {zlotoWTurach[1]}, {zlotoWTurach[0]}");


*/

// zadanie 2

/*

using System.ComponentModel;

List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura",
    "Pochodnia",
};

Console.WriteLine($"Plecak ({plecak.Count}/6)");


for (int i = 0; i < plecak.Count; i++)
{
    Console.WriteLine($"{i + 1}. {plecak[i]}");
}

Console.WriteLine("");

Console.Write("Znaleziony przedmiot: ");
string przedmiot = (Console.ReadLine()!);

plecak.Add(przedmiot);

Console.WriteLine($"Dodano: {przedmiot}");
Console.WriteLine("Użyto mikstury.");

plecak.Remove("Mikstura");

Console.WriteLine("");

Console.WriteLine($"Plecak ({plecak.Count}/6)");

for (int i = 0; i < plecak.Count; i++)
{
    Console.WriteLine($"{i + 1}. {plecak[i]}");
}

*/

//zadanie 3

/*

using System.Security.Cryptography;

Dictionary<string, int> ceny = new Dictionary<string, int>
{
    { "Mikstura", 15 },
    { "Pochodnia", 5 },
    { "Miecz", 40 }
};

Console.WriteLine("");

Console.WriteLine($"Liczba pozycji: {ceny.Count}");

foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: {para.Value}");
}

Console.WriteLine("");

Console.Write("Podaj nazwę przedmiotu: ");
string nazwa = Console.ReadLine()!;

if (ceny.ContainsKey(nazwa))
{
    Console.WriteLine($"Cena: {ceny[nazwa]} sztuk złota");
}
else
{
    Console.WriteLine("Nie ma takiego przedmiotu.");
}

ceny["Mikstura"] = 12;

Console.WriteLine("");

Console.WriteLine($"Liczba pozycji: {ceny.Count}");

foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: {para.Value}");
}

*/

// zadanie 4

/*

using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Podaj liczbę tur: ");
int tura = int.Parse(Console.ReadLine()!);

int [] zlotoWTurach = new int[tura];

for (int i = 0; i < tura; i++)
{
    Console.WriteLine($"Złoto zdobyte w turze {i + 1}: ");
    zlotoWTurach[i] = (int.Parse(Console.ReadLine()!));
}

int suma = 0;

foreach (int zloto in zlotoWTurach)
{
    suma += zloto;
}

int najmniejsze = zlotoWTurach[0];
int najwieksze = zlotoWTurach[0];

int maxWyniki = 0;

for (int i = 1; i < zlotoWTurach.Length; i++)
{
    if (zlotoWTurach[i] < najmniejsze)
    {
        najmniejsze = zlotoWTurach[i];
    }

    if (zlotoWTurach[i] > najwieksze)
    {
        najwieksze = zlotoWTurach[i];
    }
}

for (int i = 1; i < zlotoWTurach.Length; i++)
{
    if (zlotoWTurach[i] == najwieksze)
    {
        maxWyniki++;
    }
}

Console.WriteLine($"Suma: {suma}");
Console.WriteLine($"Minimum: {najmniejsze}");
Console.WriteLine($"Maksimum: {najwieksze}");
Console.WriteLine($"Liczba tur z maksimum: {maxWyniki}");


// do dokończnia 

*/