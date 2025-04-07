namespace Po1640_Klikacka.Models
{
	public class Bunka
	{
		public Bunka(byte hodnota, byte radka, byte sloupec)
		{
			Hodnota = hodnota;
			Radka = radka;
			Sloupec = sloupec;
		}

		public byte Hodnota { get; private set; }
		public byte Radka { get; }
		public byte Sloupec { get;}
		public byte StyleClassIndex { get; set; } = 0;
		public string StyleClassName => $"barva-{StyleClassIndex}";
	}
}
