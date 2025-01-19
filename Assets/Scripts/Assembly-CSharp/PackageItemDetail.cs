using System.ComponentModel;

public class PackageItemDetail : INotifyPropertyChanged
{
	private int _BackGround;

	private string _Icon;

	private int _Cost;

	private int _ItemType;

	private int _ItemValue;

	private string _ItemName;

	private string _ItemDesc;

	private int _ItemSequence;

	private int _ConsumedNumber;

	private bool _IsEquip;

	private int _WeaponValue;

	public virtual int BackGround
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual string Icon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int Cost
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int ItemType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int ItemValue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual string ItemName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string ItemDesc
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int ItemSequence
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int ConsumedNumber
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual bool IsEquip
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual int WeaponValue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public PackageItemDetail()
	{
	}

	public PackageItemDetail(long id)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
