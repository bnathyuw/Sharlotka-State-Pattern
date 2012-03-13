namespace SmallInterface.Implementation.States
{
	public interface IHasState<in T>
	{
		T State { set; }
	}
}