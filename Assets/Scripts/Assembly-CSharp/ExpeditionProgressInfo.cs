using System.ComponentModel;

public class ExpeditionProgressInfo : INotifyPropertyChanged
{
	private long _InstanceID;

	private int _Level;

	public virtual long InstanceID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual int Level
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
