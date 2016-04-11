using System;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.IO;
using System.Threading;

namespace Task6
{
	class Program
	{
		static void Main(string[] args)
		{
			//Variablendefiniton
			char ex;

			//"stream-bares" .txt generieren für observable
			TextWriter tw = new StreamWriter(@"/home/alex/stream.txt");

			do
			{
				Console.WriteLine("Timestamps werden generiert");
				//jede sekunde timestamps erzeugen
				var observable = Observable.Interval(TimeSpan.FromSeconds(1)).Timestamp();

				//timestamps ausgeben
				using (observable.Subscribe(
					x => Console.WriteLine("{0}: {1}", x.Value, x.Timestamp)))

				//timestamps in stream.txt streamen
				using (observable.Subscribe(
					x => tw.WriteLine(Convert.ToString(x.Timestamp))))

				{
					Console.WriteLine("Zum Abbrechen Eingabe");
					Console.ReadKey();
				}

				ex = Convert.ToChar(Console.ReadKey().KeyChar);
			}
			while (ex.Equals(" "));
			tw.Close();
		}
	}    
}