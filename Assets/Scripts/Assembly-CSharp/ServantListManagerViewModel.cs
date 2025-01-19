using System.Collections.Generic;
using System.Collections.Specialized;

public class ServantListManagerViewModel : ServantListManagerViewModelBase
{
	public virtual P<int> CurrentServantIndexProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int CurrentServantIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<bool> NeedShowRedStarProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool NeedShowRedStar
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual ModelCollection<ServantListItemViewModel> UserServants
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSenderAndArgument<ServantListManagerViewModel, long> TestAddServant
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ServantListManagerViewModel, string> TestChangeServant
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ServantListManagerViewModel, long> SelectSvFoDevelop
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ServantListManagerViewModel, string> SelectServantForBattle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ServantListManagerViewModel, long> ComposeSv
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ServantListManagerViewModel(ServantListManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public ServantListManagerViewModel()
		: base(null, false)
	{
	}

	protected override void WireCommands(Controller controller)
	{
	}

	public override void Write(ISerializerStream stream)
	{
	}

	public override void Read(ISerializerStream stream)
	{
	}

	public override void Unbind()
	{
	}

	protected override void FillProperties(List<ViewModelPropertyInfo> list)
	{
	}

	protected override void FillCommands(List<ViewModelCommandInfo> list)
	{
	}

	protected override void UserServantsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
