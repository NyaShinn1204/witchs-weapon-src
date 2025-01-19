using System.Collections.Specialized;

public class ServantListManagerViewModelBase : ViewModel
{
	public P<int> _CurrentServantIndexProperty;

	public P<bool> _NeedShowRedStarProperty;

	public ModelCollection<ServantListItemViewModel> _UserServantsProperty;

	protected CommandWithSenderAndArgument<ServantListManagerViewModel, long> _TestAddServant;

	protected CommandWithSenderAndArgument<ServantListManagerViewModel, string> _TestChangeServant;

	protected CommandWithSenderAndArgument<ServantListManagerViewModel, long> _SelectSvFoDevelop;

	protected CommandWithSenderAndArgument<ServantListManagerViewModel, string> _SelectServantForBattle;

	protected CommandWithSenderAndArgument<ServantListManagerViewModel, long> _ComposeSv;

	public ServantListManagerViewModelBase(ServantListManagerControllerBase controller, bool initialize = true)
	{
	}

	public ServantListManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}

	protected virtual void UserServantsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
