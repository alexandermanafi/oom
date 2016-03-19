using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.IO;
using System.Threading.Tasks;
using System.Net;

namespace Task6
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Subject<ID> subject = new Subject<ID> ();
			var subscription = subject.Subscribe (
				                   x => Consol.WriteLine ("Es wurde ein name hinzugefuegt: {0}", x),
				                   () => Console.WriteLine ("Sequenz abgeschlossen."));
			subject.OnNext (1);
			subject.OnNext (2);

			Console.WriteLine ("Um abzuschließen bitte Tastatureingabe.");
			Console.ReadKey();
			subject.OnCompleted ();
			subscription.Dispose ();

			string data = new WebClient ().DownloadString ("http://thepiratebay.sx/search/documentary");
			Console.WriteLine (data);

			//instead with continous programming:

			Task <string> newdata = new WebClient ().DownloadStringAsync ("http://thepiratebay.sx/search/documentary");
			newdata.ContinueWith(t => Console.WriteLine(t.Result));

			//or even better

			string newnewadata = await new WebClient ().DownloadStringAsync ("http://thepiratebay.sx/search/documentary");
			Console.WriteLine (newnewdata);
		
		}
	}
}
