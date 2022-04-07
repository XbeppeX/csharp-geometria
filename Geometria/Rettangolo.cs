using System;
namespace Geometria
{
	public class Rettangolo
	{
		
		private int baseRettangolo;
		private int altezzaRettangolo;
		

		

		public void StampaRettangolo(int baseRettangolo1, int altezzaRettangolo1)
        {
			baseRettangolo = baseRettangolo1;
			altezzaRettangolo = altezzaRettangolo1;
			int area = baseRettangolo1 * altezzaRettangolo1;
			int perimetro = (baseRettangolo1 + altezzaRettangolo1) * 2;
			Console.WriteLine("---Rettangolo---");
			Console.WriteLine("base: " + baseRettangolo + " cm");
			Console.WriteLine("altezza: " + altezzaRettangolo + " cm");
			Console.WriteLine("perimetro: " + perimetro + " cm");
			Console.WriteLine("area: " + area + " cm2");
		}

		/*
		 * public void StampaArea(int baseRettangolo1, int altezzaRettangolo1)
        {
			baseRettangolo = baseRettangolo1;
			altezzaRettangolo = altezzaRettangolo1;
			int area = baseRettangolo1 * altezzaRettangolo1;
			Console.WriteLine("area: " + area + " cm");
		}

		

		public int calcolaPerimetro(int baseRettangolo1, int altezzaRettangolo1)
        {
			baseRettangolo = baseRettangolo1;
			altezzaRettangolo = altezzaRettangolo1;
			int perimetro = (baseRettangolo1 + altezzaRettangolo1) * 2;
			return perimetro;
			
        }
		 *
		 */






	}
}

