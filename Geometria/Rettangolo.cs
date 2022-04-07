using System;
namespace Geometria
{
	public class Rettangolo
	{
		
		private int baseRettangolo;
		private int altezzaRettangolo;
		private int perimetro;
		private int area;

		public Rettangolo(int baseRettangolo1, int altezzaRettangolo1)
		{
			baseRettangolo = baseRettangolo1;
			altezzaRettangolo = altezzaRettangolo1;
			perimetro = calcolaPerimetro(baseRettangolo1, altezzaRettangolo1);
			area = calcolaArea(baseRettangolo1, altezzaRettangolo1);
		}

		public int calcolaPerimetro(int baseRettangolo1, int altezzaRettangolo1)
		{
			baseRettangolo = baseRettangolo1;
			altezzaRettangolo = altezzaRettangolo1;
			int perimetro = (baseRettangolo1 + altezzaRettangolo1) * 2;
			return perimetro;

		}

		public int calcolaArea(int baseRettangolo1, int altezzaRettangolo1)
		{
			baseRettangolo = baseRettangolo1;
			altezzaRettangolo = altezzaRettangolo1;
			int area = baseRettangolo1 * altezzaRettangolo1;
			return area;
		}

		public void StampaRettangolo()
        {
			Console.WriteLine("---Rettangolo---");
			Console.WriteLine("base: " + baseRettangolo + " cm");
			Console.WriteLine("altezza: " + altezzaRettangolo + " cm");
			Console.WriteLine("perimetro: " + perimetro + " cm");
			Console.WriteLine("area: " + area + " cm2");
		}

		





	}
}

