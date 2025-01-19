using System.ComponentModel;

public class RuneMountArgu : INotifyPropertyChanged
{
	private long _SvID;

	private long _SlotIndex;

	private long _RuneID;

	public virtual long SvID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual long SlotIndex
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual long RuneID
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
