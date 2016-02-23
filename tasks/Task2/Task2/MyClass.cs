using System;

namespace Task2
{
	class PVModule
	{
		private string name;
		private decimal price;

		public decimal kW
		{
			get 
			{
				return kW;
			}
			set 
			{
				if (value < 0) throw new Exception ("kw must not be negative!");
				kW = value;
			}
		}

		public string brand
		{
			get
			{
				return brand;
			}
			set
			{
				brand = value;
			} 
		}

		
		public PVModule(string newname, decimal newprice)
		{
			name = newname;

			if (newprice < 0) throw new ArgumentOutOfRangeException("Price must not be negative.");
			price = newprice;
		}

		public decimal writeprice()
		{
			Console.WriteLine ("The price is {0}", price);
		}
	}
		
}

PVModule A = new PVModule("BPXYA", 120, "Trina Solar", 199);

Console.WriteLine("price of BPXYA is {0}", A.price);

A.writeprice();


