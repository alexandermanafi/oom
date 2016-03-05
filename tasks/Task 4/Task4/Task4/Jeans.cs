using System;
using NUnit.Framework;

namespace Task4
{
	[TestFixture]
	public class Jeans : IKleidung
	{

		public string m_marke{ get; set; }
		public string m_farbe{ get; set;}
		public int m_größe{ get; set; }
		private double m_preis{ get; set; }
		
		public Jeans(string Marke, string Farbe, int Größe, double Preis)
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
		public void UpdatePrice(double newprice)
		{
			if (newprice < 0) throw new ArgumentOutOfRangeException ("Preis darf nicht kleiner 0 sein.");

			m_preis = newprice;
		}

		[Test]
		public void GreenishFarbe()
		{
			m_farbe = "Grün";
		}

		[Test]
		public void DoublePrice()
		{
			m_preis = m_preis * 2;
		}

	}

}

