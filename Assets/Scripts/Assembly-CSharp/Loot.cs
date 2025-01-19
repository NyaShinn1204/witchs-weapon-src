using System.ComponentModel;

public class Loot : INotifyPropertyChanged
{
	private string _lootID;

	private int _lootType;

	private string _itemIcon;

	private int _itemQuality;

	private int _ItemSubType;

	public virtual string lootID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int lootType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual string itemIcon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int itemQuality
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int ItemSubType
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

	public Loot()
	{
	}

	public Loot(long id, GlobalEnum.ResType type)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
