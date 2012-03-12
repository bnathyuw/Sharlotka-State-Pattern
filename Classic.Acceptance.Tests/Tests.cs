using Classic.Implementation;
using NUnit.Framework;

namespace Classic.Acceptance.Tests
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void Happy_path() {
			var sharlotka = new Sharlotka();
			sharlotka.AddApples();
			sharlotka.AddBatter();
			sharlotka.Bake();
			while (!sharlotka.IsReady) {
				sharlotka.Bake();
			}
			sharlotka.TurnOut();
			sharlotka.DustWithSugar();
			sharlotka.DustWithCinnamon();
			sharlotka.Serve();
		}
	}
}