using System.Collections.Generic;

public class ServantWeaponExpItemViewModel : ServantWeaponExpItemViewModelBase
{
	private CurrentServantWeaponInfoViewModel _ParentCurrentServantWeaponInfo;

	public virtual P<long> IDProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long ID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<int> NumProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Num
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<PackageItemDetail> InfoProperty
	{
		get
		{
			return null;
		}
	}

	public virtual PackageItemDetail Info
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CurrentServantWeaponInfoViewModel ParentCurrentServantWeaponInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ServantWeaponExpItemViewModel(ServantWeaponExpItemControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public ServantWeaponExpItemViewModel()
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
