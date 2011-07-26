using Nancy;
using Nancy.Session;

namespace NancyCookiesProblem
{
	public class TestBootstrapper : DefaultNancyBootstrapper
	{
		protected override void InitialiseInternal(TinyIoC.TinyIoCContainer container)
		{
			base.InitialiseInternal (container);

			CookieBasedSessions.Enable (this);
		}
	}
}
