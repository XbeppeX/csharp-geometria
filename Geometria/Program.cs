
using Geometria;

Console.WriteLine("Inserisci base rettangolo");
int baseRettangolo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci altezza rettangolo");
int altezzaRettangolo = Convert.ToInt32(Console.ReadLine());

Rettangolo rettangolo1 = new Rettangolo();

rettangolo1.StampaRettangolo(baseRettangolo, altezzaRettangolo);

