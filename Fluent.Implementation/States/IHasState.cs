namespace Fluent.Implementation.States
{
	public interface IHasState<in T>
	{
		T State { set; }
	}
}