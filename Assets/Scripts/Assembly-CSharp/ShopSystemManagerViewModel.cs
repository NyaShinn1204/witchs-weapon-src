using System.Collections.Generic;

public class ShopSystemManagerViewModel : ShopSystemManagerViewModelBase
{
	public virtual P<string> BuyResultProperty
	{
		get
		{
			return null;
		}
	}

	public virtual string BuyResult
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<string> PayResultProperty
	{
		get
		{
			return null;
		}
	}

	public virtual string PayResult
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual ModelCollection<ShopSet> AllShopSets
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<DrawResultData> BuyLoots
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<DrawResultData> ExtraWeapon
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSenderAndArgument<ShopSystemManagerViewModel, long> ManulRefresh
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ShopSystemManagerViewModel, string> RefreshOutofDateShopSet
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ShopSystemManagerViewModel> FinishRefresh
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ShopSystemManagerViewModel, BuyGoodArug> BuyGood
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ShopSystemManagerViewModel> FinishBuyGood
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<ShopSystemManagerViewModel> FinishPay
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ShopSystemManagerViewModel, BuyGoodArug> CreatePay
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<ShopSystemManagerViewModel, string> RefreshManagerShopSet
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ShopSystemManagerViewModel(ShopSystemManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public ShopSystemManagerViewModel()
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
