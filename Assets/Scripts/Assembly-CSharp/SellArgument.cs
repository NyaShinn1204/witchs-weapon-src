using System.ComponentModel;

public class SellArgument : INotifyPropertyChanged
{
	private long _id;

	private int _num;

	private long _addgold;

	private int _addgoldtype;

	private int _ItemType;

	private long targetItem;

	public virtual long id
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual int num
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual long addgold
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual int addgoldtype
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

	public long TargetItem
	{
		get
		{
			return 0L;
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
