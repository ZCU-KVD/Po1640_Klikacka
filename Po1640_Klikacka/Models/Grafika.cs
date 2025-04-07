namespace Po1640_Klikacka.Models
{
	public class Grafika
	{
		public Grafika()
		{
			VytvorPoleBunek(pocetRadek: 8, pocetSloupcu: 12, minCislo: 0, maxCislo: 1);
		}
		public Grafika(byte pocetRadek, byte pocetSloupcu, byte pocetBarev = 4)
		{
			VytvorBarvySeznam(pocetBarev);
			VytvorPoleBunek(pocetRadek: pocetRadek, pocetSloupcu: pocetSloupcu, minCislo: 0, maxCislo: pocetBarev);
			ZvolenaBarva = 3;
			BarvySeznam[ZvolenaBarva].Selected = true;
		}
		public Bunka[,] PoleBunek { get; set; }
		public List<BunkaSeznam> BarvySeznam { get; set; } = new List<BunkaSeznam>();
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

		private void VytvorBarvySeznam(byte pocetBarev)
		{
			BarvySeznam.Clear();
			for (byte i = 0; i <= pocetBarev; i++)
			{
				BarvySeznam.Add(new BunkaSeznam(i));
			}
		}

		public void OnClickCell(Bunka bunka, bool viceBarev = false)
		{
			//if (viceBarev)
			//{
			//	bunka.StyleClassIndex = ZvolenaBarva;
			//	return;
			//}

			if (bunka.Hodnota == 0 && bunka.StyleClassIndex != ZvolenaBarva || viceBarev)
			{
				bunka.StyleClassIndex = ZvolenaBarva;
			}
			else
			{
				bunka.StyleClassIndex = 0;
			}
		}

		public void OnClickCell(BunkaSeznam bunka)
		{
			foreach (var item in BarvySeznam)
			{
				item.Selected = false;
			}
			bunka.Selected = true;
			ZvolenaBarva = bunka.Hodnota;
		}
	}
}
