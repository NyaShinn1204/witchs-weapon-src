using System.ComponentModel;

public class ItemClient : INotifyPropertyChanged
{
	private int _ID;

	private int _itemName;

	private int _itemDesc;

	private string _itemIcon;

	private int _itemQuality;

	private int _itemGain;

	private int _itemGainInstance1;

	private int _itemGainInstance2;

	private int _itemGainInstance3;

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

	public virtual int itemName
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int itemDesc
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

	public virtual int itemGain
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int itemGainInstance1
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int itemGainInstance2
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int itemGainInstance3
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
