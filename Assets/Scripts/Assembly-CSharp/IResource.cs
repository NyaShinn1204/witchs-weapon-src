public interface IResource
{
	void OnBorrow();

	void OnReturn();

	void OnCloneComplete();

	void OnFullFill();
}
