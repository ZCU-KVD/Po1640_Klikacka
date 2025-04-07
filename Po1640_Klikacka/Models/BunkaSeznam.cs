namespace Po1640_Klikacka.Models
{
	public class BunkaSeznam : Bunka
	{
		public BunkaSeznam(byte sloupec) : base(hodnota: sloupec,radka: 0, sloupec: sloupec)
		{
			StyleClassIndex = sloupec;
		}

		public bool Selected { get; set; } = false;

		private string StyleClassNameSelected => Selected ? "selected" : string.Empty;
		public override string StyleClassName => $"{base.StyleClassName} {StyleClassNameSelected}".Trim();
	}
}
