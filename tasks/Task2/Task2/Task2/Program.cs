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

			var arr = new Solarmodul["Trina Solar","TS315", "Yingli", "YS315", "TSMC", "TSM315"];

			for (var i = 0; i < 3; i++)
			{
				Console.WriteLine(arr.name);
			}
		
		}

		interface A
		{
			void UpdatePreis();
		}

		class Solarmodul : A
		{
			private decimal m_preis;

			public Solarmodul(string name, string marke)
			{
				if (string.IsNullOrWhiteSpace(marke)) throw new ArgumentException("marke darf nicht leer sein.", nameof(marke));
				if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("name darf nicht leer sein.", nameof(name));
			
				Name = name;
				Marke = marke;
			}

			public string Name { get; }
			public string Marke { get; }

			public decimal GetPreis()
			{ 
				return m_preis;
			}

			public override void UpdatePreis(decimal value)
			{
				m_preis = value;
			}
		}

		class Wechselrichter : A
		{
			private decimal m_preis;

			public Wechselrichter (string name, string marke)
			{
				if (string.IsNullOrWhiteSpace(marke)) throw new ArgumentException("marke darf nicht leer sein.", nameof(marke));
				if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("name darf nicht leer sein.", nameof(name));

				Name = name;
				Marke = marke;
			}

			public decimal GetPreis()
			{ 
				return m_preis;
			}

			public override void UpdatePreis(decimal value)
			{
				m_preis = value * 0.75;
			}
		}
	}
}
