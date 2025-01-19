using System.ComponentModel;

public class HireArgu : INotifyPropertyChanged
{
	private long _SvID;

	private long _RoleID;

	private long _AddTime;

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

	public virtual long RoleID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual long AddTime
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

	public HireArgu(long rid, long sid, long time)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
