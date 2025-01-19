public interface IViewModelObserver
{
	void AddBinding(IBinding binding);

	void RemoveBinding(IBinding binding);

	void Unbind();
}
