using System.ComponentModel;

public class SinglePackageInfo : INotifyPropertyChanged
{
	private int _ID;

	private int _number;

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

	public virtual int number
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
