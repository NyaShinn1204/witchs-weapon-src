using System.ComponentModel;

public class Item : INotifyPropertyChanged
{
	private int _ID;

	private int _itemClientID;

	private int _itemType;

	private int _itemAppear;

	private int _itemSequence;

	private int _maxStack;

	private int _sellPrice;

	private int _favorabilityValue;

	private int _itemLootID;

	public virtual int ID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int itemClientID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int itemType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int itemAppear
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int itemSequence
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int maxStack
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int sellPrice
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int favorabilityValue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int itemLootID
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

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
