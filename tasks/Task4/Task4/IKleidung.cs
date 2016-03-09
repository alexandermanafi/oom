using System;
using NUnit.Framework;

namespace Task4
{
	public interface IKleidung
	{
		string Farbe{get; set;}
		string Marke{get; set;}
		string Groesse{get; set;}
		double Preis{get; set;} 

		void UpdatePreis (double newprice);
	}
}