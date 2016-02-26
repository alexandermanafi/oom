using System;

namespace Task2
{
	public class EmptyClass
	{
		public EmptyClass ()
		{
		}
	}
}

var webclient = new System.Net.WebClient();
var url = "https://github.com/bicoom/oom/wiki/Lesson-2.md";
var text = webclient.DownloadString(url);
Console.WriteLine(text);