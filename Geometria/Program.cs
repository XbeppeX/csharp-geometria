
using Geometria;


while (true)
{
    Console.WriteLine("Dimmi se vuoi aggiungere rettango [Si/No]? ");
    string risposta = Console.ReadLine().ToLower();

    switch (risposta)
    {
        case "si":
            Console.WriteLine("Inserisci base rettangolo");
            int baseRettangolo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci altezza rettangolo");
            int altezzaRettangolo = Convert.ToInt32(Console.ReadLine());

            Rettangolo rettangolo1 = new Rettangolo(baseRettangolo, altezzaRettangolo);

            rettangolo1.StampaRettangolo();
            Console.WriteLine("");
            break;
        case "no":
            Console.WriteLine("Grazie");
            Console.WriteLine("");
            break;
        default:
            Console.WriteLine("Mi dispiace opzione non contemplata");
            break;
    }
}