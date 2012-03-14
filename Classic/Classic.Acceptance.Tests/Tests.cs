using Classic.Implementation;
using Classic.Implementation.DependencyInjection;
using Classic.Implementation.States;
using NUnit.Framework;
using StructureMap;

namespace Classic.Acceptance.Tests
{
	[TestFixture]
	public class Tests
	{
		private IContainer _container;

		[SetUp]
		public void SetUp() {
			_container = DependencyResolver.Container;
		}

		[Test]
		public void Happy_path() {
			var sharlotka = _container.GetInstance<ISharlotka>();
			sharlotka.AddApples();
			sharlotka.AddBatter();
			do {
				sharlotka.Bake();
			} while (!sharlotka.GetIsReady()); 
			sharlotka.TurnOut();
			sharlotka.DustWithSugar();
			sharlotka.DustWithCinnamon();
			sharlotka.Serve();
		}

		[Test]
		public void Throws_WrongStateException_if_methods_are_called_out_of_turn() {
			var sharlotka = _container.GetInstance<ISharlotka>();
			
			Assert.Throws<WrongStateException>(sharlotka.AddBatter);
			Assert.Throws<WrongStateException>(sharlotka.Bake);
			Assert.Throws<WrongStateException>(() => sharlotka.GetIsReady());
			Assert.Throws<WrongStateException>(sharlotka.TurnOut);
			Assert.Throws<WrongStateException>(sharlotka.DustWithSugar);
			Assert.Throws<WrongStateException>(sharlotka.DustWithCinnamon);

			sharlotka.AddApples();

			Assert.Throws<WrongStateException>(sharlotka.AddApples); 
			Assert.Throws<WrongStateException>(sharlotka.Bake);
			Assert.Throws<WrongStateException>(() => sharlotka.GetIsReady());
			Assert.Throws<WrongStateException>(sharlotka.TurnOut);
			Assert.Throws<WrongStateException>(sharlotka.DustWithSugar);
			Assert.Throws<WrongStateException>(sharlotka.DustWithCinnamon);
		}
	}
}