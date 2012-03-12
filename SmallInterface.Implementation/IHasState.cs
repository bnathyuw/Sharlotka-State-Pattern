namespace SmallInterface.Implementation
{
	public interface IHasState<in T>
	{
		T State { set; }
	}
}