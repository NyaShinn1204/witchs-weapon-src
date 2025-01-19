using System.Collections.Generic;

public class FashionSystemManagerViewModel : FashionSystemManagerViewModelBase
{
	public virtual P<FashionInfo> CurrentFashionProperty
	{
		get
		{
			return null;
		}
	}

	public virtual FashionInfo CurrentFashion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual ModelCollection<FashionInfo> Fashions
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSenderAndArgument<FashionSystemManagerViewModel, long> SelectFashion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<FashionSystemManagerViewModel, long> BuyFashion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<FashionSystemManagerViewModel> RefreshFashion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<FashionSystemManagerViewModel> FinishRefresh
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public FashionSystemManagerViewModel(FashionSystemManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public FashionSystemManagerViewModel()
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
}
