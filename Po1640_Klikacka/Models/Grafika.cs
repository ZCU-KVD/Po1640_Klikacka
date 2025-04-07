namespace Po1640_Klikacka.Models
{
	public class Grafika
	{
		public Grafika()
		{
			VytvorPoleBunek(pocetRadek: 8, pocetSloupcu: 12, minCislo: 0, maxCislo: 1);
		}

		public Bunka[,] PoleBunek { get; set; }
		public byte ZvolenaBarva { get; set; } = 3;

		private void VytvorPoleBunek(byte pocetRadek, byte pocetSloupcu, byte minCislo, byte maxCislo)
		{
			PoleBunek = new Bunka[pocetRadek, pocetSloupcu];
			for (byte i = 0; i < pocetRadek; i++)
			{
				for (byte j = 0; j < pocetSloupcu; j++)
				{
					PoleBunek[i, j] = new Bunka(Global.DejNahodneCislo(minCislo,maxCislo),i,j);
				}
			}
		}

		public void OnClickCell(Bunka bunka)
		{
			if (bunka.Hodnota == 0 && bunka.StyleClassIndex != ZvolenaBarva)
			{
				bunka.StyleClassIndex = ZvolenaBarva;
			}
			else
			{
				bunka.StyleClassIndex = 0;
			}
		}
	}
}
