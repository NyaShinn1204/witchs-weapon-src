using System.ComponentModel;

public class DrawArgu : INotifyPropertyChanged
{
	private int _type;

	private long _actID;

	public virtual int type
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual long actID
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

	public DrawArgu(int type, long actid = 0L)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
