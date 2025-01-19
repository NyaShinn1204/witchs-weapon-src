using System.ComponentModel;

public class FashionInfo : INotifyPropertyChanged
{
	private long _ID;

	private long _Name;

	private long _Description;

	private int _Serial;

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

	public virtual long Name
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual long Description
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual int Serial
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsOwn { get; set; }

	public event PropertyChangedEventHandler PropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public FashionInfo(long ID)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
