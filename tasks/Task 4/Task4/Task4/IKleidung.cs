using System;
using NUnit.Framework;

namespace Task4
{
	
	public interface IKleidung
	{
		string m_marke{ get; set; }

		void UpdatePrice(double newpreis);

		double GetPrice();
	}
}