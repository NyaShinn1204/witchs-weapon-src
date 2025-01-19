public class RuneItemViewModelBase : ViewModel
{
	public P<long> _IDProperty;

	public P<long> _RuneIDProperty;

	public RuneItemViewModelBase(RuneItemControllerBase controller, bool initialize = true)
	{
	}

	public RuneItemViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
