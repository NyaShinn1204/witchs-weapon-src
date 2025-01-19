using System.Collections.Generic;

public class PackageItemViewModel : PackageItemViewModelBase
{
	private PackageManagerViewModel _ParentPackageManager;

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

	public virtual P<string> NameProperty
	{
		get
		{
			return null;
		}
	}

	public virtual string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<long> NumProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long Num
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<PackageItemDetail> DetailProperty
	{
		get
		{
			return null;
		}
	}

	public virtual PackageItemDetail Detail
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual PackageManagerViewModel ParentPackageManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public PackageItemViewModel(PackageItemControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public PackageItemViewModel()
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
