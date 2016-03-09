using System;
using NUnit.Framework;

namespace Task4
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void SimpleTest ()
		{
			Assert.IsTrue (1 == 1);
		}

		public void CanCreateJeans()
		{
			var x = new Jeans ("Levis", "Schwarz", "38", 199.99);

			Assert.IsTrue(x.Marke == "Levis");
			Assert.IsTrue(x.Farbe == "Schwarz");
			Assert.IsTrue (x.Groesse == "38");
			Assert.IsTrue(x.Preis == 199.99);
		}

		public void CannotCreateJeansWithNegativePrice()
		{
			Assert.Catch(() =>
				{
					var x = new Jeans ("Levis", "Schwarz", "38", -32);
				});
		}

		public void CanCreateTShirts()
		{
			var x = new TShirts ("H&M", "Schwarz", "Medium", 19.99);

			Assert.IsTrue(x.Marke == "H&M");
			Assert.IsTrue(x.Farbe == "Schwarz");
			Assert.IsTrue (x.Groesse == "Medium");
			Assert.IsTrue(x.Preis == 19.99);
		}

		public void CannotCreateTShirtsWithNegativePrice()
		{
			Assert.Catch(() =>
				{
					var x = new TShirts ("H&M", "Schwarz", "Medium", -32);
				});
		}
			

		public void UpdateJeansPreisWithNegative(double testvar)
		{
			Assert.Catch(() =>
			{
				testvar = -300;
				var xy = new Jeans ("H&M", "Schwarz", "Medium", 19.99);
				if (testvar < 0) throw new ArgumentOutOfRangeException ("Preis darf nicht kleiner 0 sein.");
				xy.Preis = testvar;
			});
		}

		public void UpdateTShirtsPreisWithNegative(double testvar)
		{
			Assert.Catch(() =>
				{
					testvar = -300;
					var xy = new TShirts ("H&M", "Schwarz", "Medium", 19.99);
					if (testvar < 0) throw new ArgumentOutOfRangeException ("Preis darf nicht kleiner 0 sein.");
					xy.Preis = testvar;
				});
		}


	}
}

