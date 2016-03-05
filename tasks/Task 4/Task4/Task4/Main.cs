using System;
using NUnit.Framework;
using Newtonsoft.Json;
using System.IO;

namespace Task4
{
	[TestFixture]
	class MainClass
	{
		[Test]
		public static void Main (string[] args)
		{
			Console.WriteLine ("\t\tJeans-Shop 101\n");

			//Objekte definieren
			Jeans a = new Jeans ("Levis", "Blau", 31, 99);
			Jeans b = new Jeans ("Denimwear", "Schwarz", 34, 49);
			Jeans c = new Jeans ("Cheapwear", "Beige", 41, 19);
			TShirts d = new TShirts ("Kanye West", "Weiß", "M", 49.99);

			//Testweise Member der Objekte ausgeben
			Console.WriteLine ("Preis von T-Shirt d der Marke {0} zum Zeitpunkt 1: {1}", d.m_marke, d.GetPrice());
			Console.WriteLine ("Preis von Jean a der Marke {0} zum Zeitpunkt 1: {1}", a.m_marke, a.GetPrice());
			Console.WriteLine ("Preis von Jean b der Marke {0} zum Zeitpunkt 1: {1}", b.m_marke, b.GetPrice());
			Console.WriteLine ("Preis von Jean c der Marke {0} zum Zeitpunkt 1: {1}", c.m_marke, c.GetPrice ());

			//Preis für ein Objekt mit UpdatePrice ändern und aktualisierten preis ausgeben
			Console.WriteLine ("\nBitte neuen Preis für Jean a schreiben:");
			double a_preis = Convert.ToDouble(Console.ReadLine());;
			a.UpdatePrice (a_preis);
			Console.WriteLine ("\nPreis von Jeans a der Marke {0} zum Zeitpunkt 2: {1}\n", a.m_marke, a.GetPrice());

			//Array mit Objekten der Instanz IKleidung definieren


			var kleidungsitems = new IKleidung[]
			{
				new Jeans ("Calvin Klein", "Blau", 32, 299.99),
				new Jeans ("Unix", "Grau", 45, 9),
				new TShirts("H&M", "Schwarz", "XXL", 9),
				new TShirts("Diesel", "Schwarz", "XS", 49.99)
			};

			//Zufallszahl initialisieren, mit foreach-Loop das Array durchgehen, 
			//UpdatePrice mit Zufallszahl aufrufen und in Konsole ausgeben
			Random rnd = new Random();

			foreach(var i in kleidungsitems)
			{
				i.UpdatePrice (rnd.Next(1,1000));
				Console.WriteLine ("Zufallspreis für {0} ist {1}", i.m_marke, i.GetPrice ());
			}


			//JSon

			var DiverseJeans = new Jeans[] 
			{
				new Jeans ("Jason", "Jellow", 7, 77),
				new Jeans ("Yeah", "Esgeht", 10, 100)
			};

			//Write array in file
			foreach(var i in DiverseJeans)
			{
				File.WriteAllText(@"/home/alex/oom/tasks/Task 4/Task4/Task4/Jeans.json", JsonConvert.SerializeObject(i));
			}
			Console.WriteLine("Objekt wurde in File geschrieben. \n");

			//Read object from file and print it to console
			Jeans SpecialJeans = JsonConvert.DeserializeObject<Jeans>(File.ReadAllText(@"/home/alex/oom/tasks/Task 4/Task4/Task4/Jeans_special.json"));

			Console.WriteLine ("Das importierte Jeans-Objekt hat die Marke {0}, den Preis {1}, die Farbe {2} und die Größe{3} \n", SpecialJeans.m_marke, SpecialJeans.GetPrice(), SpecialJeans.m_farbe, SpecialJeans.m_größe);

			Console.WriteLine("Nun in Json-Notation \n");
			string json = JsonConvert.SerializeObject(SpecialJeans, Formatting.Indented);
			Console.WriteLine(json);
		}
	}
}
	