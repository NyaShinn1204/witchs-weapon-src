using System.ComponentModel;

public class SweepArgu : INotifyPropertyChanged
{
	private string _SetID;

	private string _InstanceID;

	private string _Count;

	public virtual string SetID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string InstanceID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string Count
	{
		get
		{
			return null;
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
