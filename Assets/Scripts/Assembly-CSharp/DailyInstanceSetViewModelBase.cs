using System.Collections.Specialized;

public class DailyInstanceSetViewModelBase : ViewModel
{
	public P<long> _IdProperty;

	public P<int> _EnterCountsProperty;

	public ModelCollection<DailyInstanceViewModel> _LevelsProperty;

	public DailyInstanceSetViewModelBase(DailyInstanceSetControllerBase controller, bool initialize = true)
	{
	}

	public DailyInstanceSetViewModelBase()
	{
	}

	public override void Bind()
	{
	}

	protected virtual void LevelsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
