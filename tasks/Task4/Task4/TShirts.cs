using System;
using NUnit.Framework;

namespace Task4
{
	public class TShirts : IKleidung
	{
		private string m_marke;
		private string m_groesse;
		private string m_farbe;
		private double m_preis;

		public string Marke
		{
			get
			{
				return m_marke;
			}

			set
			{
				m_marke = value;
			}
		}

		public string Farbe
		{
			get
			{
				return m_farbe;
			}

			set
			{
				m_farbe = value;
			}
		}

		public string Groesse
		{
			get
			{
				return m_groesse;
			}

			set
			{
				m_groesse = value;
			}
		}

		public double Preis
		{
			get
			{
				return m_preis;
			}

			set
			{
				if (value < 0) throw new Exception ("Preis darf nicht negativ sein.");
				m_preis = value;
			}
		}


		public TShirts(string Marke, string Farbe, string Groesse, double Preis)
		{
			if (Preis < 0) throw new ArgumentOutOfRangeException ("Preis darf nicht kleiner 0 sein.");

			m_marke = Marke; 
			m_farbe = Farbe;
			m_groesse = Groesse;
			m_preis = Preis;
		}

		public void UpdatePreis(double newprice)
		{
			if (newprice < 0) throw new ArgumentOutOfRangeException ("Preis darf nicht kleiner 0 sein.");

			m_preis = newprice;
		}
	}
}

