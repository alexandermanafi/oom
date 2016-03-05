using System;
using NUnit.Framework;

namespace Task4
{
	[TestFixture]

	public class TShirts : IKleidung
	{
		public string m_marke{ get; set; }
		public string m_größe{ get; set; }
		public string m_farbe{ get; set; }
		private double m_preis{ get; set; }


		public TShirts(string Marke, string Farbe, string Größe, double Preis)
		{
			if (Preis < 0) throw new ArgumentOutOfRangeException ("Preis darf nicht kleiner 0 sein.");

			m_marke = Marke; 
			m_farbe = Farbe;
			m_größe = Größe;
			m_preis = Preis;
		}

		[Test]
		public double GetPrice()
		{
			return m_preis;
		}

		[Test]
		public void UpdatePrice(double newpreis)
		{
			if (newpreis < 0) throw new ArgumentOutOfRangeException ("Preis muss größer 0 sein");
			m_preis = newpreis;
		}

		[Test]
		public void DoublePrice()
		{
			m_preis = m_preis * 2;
		}
	}
}

