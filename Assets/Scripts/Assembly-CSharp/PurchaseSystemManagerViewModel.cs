using System.Collections.Generic;

public class PurchaseSystemManagerViewModel : PurchaseSystemManagerViewModelBase
{
	public virtual P<bool> BuyGoldSignalProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool BuyGoldSignal
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<int> MultProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Mult
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<long> RMBProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long RMB
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<int> VitNowProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int VitNow
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> VitTimeProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int VitTime
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<string> BuyGoldResultProperty
	{
		get
		{
			return null;
		}
	}

	public virtual string BuyGoldResult
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<bool> BuyVitSignalProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool BuyVitSignal
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<string> BuyVitResultProperty
	{
		get
		{
			return null;
		}
	}

	public virtual string BuyVitResult
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<long> GoldProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long Gold
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<PurchaseSystemManagerViewModel> BuyGold
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<PurchaseSystemManagerViewModel> BuyVit
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public PurchaseSystemManagerViewModel(PurchaseSystemManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public PurchaseSystemManagerViewModel()
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
