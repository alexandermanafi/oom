using System;

namespace Task2
{
	public class task2_program
	{
		public static void Main(string[] args)
		{
			Solarmodul modul_a = new Solarmodul ("TS320", "Trina Solar");
			Solarmodul modul_b = new Solarmodul ("YS340", "Yingli Solar");

			Console.WriteLine ("{0}  {1} \n", modul_a.Marke, modul_a.Name);
			Console.WriteLine ("{0}  {1} \n", modul_b.Marke, modul_b.Name);
		}

		class Solarmodul
		{
			private decimal m_preis;

			public Solarmodul(string name, string marke)
			{
				if (string.IsNullOrWhiteSpace(marke)) throw new ArgumentException("marke must not be empty.", nameof(marke));
				if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("name must not be empty.", nameof(name));
			
				Name = name;
				Marke = marke;
			}

			public string Name { get; }
			public string Marke { get; }

			public decimal GetPreis()
			{ 
				return m_preis;
			}

			public void UpdatePreis(decimal value)
			{
				m_preis = value;
			}
		}
	}
}
