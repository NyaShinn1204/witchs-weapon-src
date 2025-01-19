public class DailyInstanceViewModelBase : ViewModel
{
	public P<long> _IDProperty;

	public P<bool> _CanFightProperty;

	public P<bool> _IsPassProperty;

	public DailyInstanceViewModelBase(DailyInstanceControllerBase controller, bool initialize = true)
	{
	}

	public DailyInstanceViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
