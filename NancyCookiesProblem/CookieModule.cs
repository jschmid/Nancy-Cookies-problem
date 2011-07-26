using Nancy;

namespace NancyCookiesProblem
{
	public class CookieModule : NancyModule
	{
		public CookieModule()
		{
			Get["/"] = parameters =>
			{
				string ret = Session["last"] as string;

				Session["last"] = System.DateTime.Now.ToString ();

				return ret;
			};
		}
	}
}
