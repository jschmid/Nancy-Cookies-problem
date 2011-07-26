using System;
using Nancy.Hosting.Self;

namespace NancyCookiesProblem
{
	class Program
	{
		static void Main(string[] args)
		{
			var nancyHost = new NancyHost (new Uri ("http://localhost:8888/"));
			nancyHost.Start ();

			Console.WriteLine ("Nancy now listening - navigating to http://localhost:8888/. Press enter to stop");
			Console.ReadLine ();

			nancyHost.Stop ();

			Console.WriteLine ("Stopped. Good bye!");
		}
	}
}
