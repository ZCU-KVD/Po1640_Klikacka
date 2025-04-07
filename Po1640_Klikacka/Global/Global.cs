namespace Po1640_Klikacka
{
	public static class Global
	{
		private static Random rnd = new Random();

		/// <summary>
		/// Vrátí náhodné číslo z intervalu <paramref name="min"/> až <paramref name="max"/>.
		/// </summary>
		/// <param name="min">minimu včetně</param>
		/// <param name="max"> maximum včetně</param>
		/// <returns></returns>
		public static byte DejNahodneCislo(byte min, byte max)
		{
			return (byte)(rnd.Next(min, max + 1));
			//return (byte)Math.Floor(rnd.NextDouble() * (max - min + 1) + min);
		}
	}
}
