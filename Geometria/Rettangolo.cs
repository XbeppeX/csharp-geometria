using System;
namespace Geometria
{
	public class Rettangolo
	{
		
		private int baseRettangolo;
		private int altezzaRettangolo;
		
		public Rettangolo(int baseRettangolo1, int altezzaRettangolo1)
		{
			baseRettangolo = baseRettangolo1;
			altezzaRettangolo = altezzaRettangolo1;
		
		}

		public int calcolaPerimetro()
		{
			int perimetro = (baseRettangolo + altezzaRettangolo) * 2;
			return perimetro;

		}

		public int calcolaArea()
		{
			int area = baseRettangolo * altezzaRettangolo;
			return area;
		}

		public void StampaRettangolo()
        {
			Console.WriteLine("---Rettangolo---");
			Console.WriteLine("base: " + baseRettangolo + " cm");
			Console.WriteLine("altezza: " + altezzaRettangolo + " cm");
			Console.WriteLine("perimetro: " + calcolaPerimetro() + " cm");
			Console.WriteLine("area: " + calcolaPerimetro() + " cm2");
		}

		public void Disegno()
        {
			
			Console.Write("|");

			for (int i=0; i < baseRettangolo; i++)
			{
				Console.Write("--");

			}

			Console.WriteLine("|");

			Console.Write("|");
			for (int i=0; i < altezzaRettangolo-1; i++)
			{

				
				Console.Write("a");
				Console.Write("|");


			}

			Console.Write("|");

			Console.WriteLine("");

			Console.Write("|");

			for (int i = 0; i < baseRettangolo; i++)
			{
				Console.Write("--");

			}

			Console.Write("|");

		}

		
		


	}
}

