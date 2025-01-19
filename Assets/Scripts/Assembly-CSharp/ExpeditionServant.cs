using System.ComponentModel;

public class ExpeditionServant : INotifyPropertyChanged
{
	private long _ID;

	private long _Energy;

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

	public virtual long Energy
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
