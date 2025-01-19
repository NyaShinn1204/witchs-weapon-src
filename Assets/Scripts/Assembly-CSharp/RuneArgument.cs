using System.Collections.Generic;
using System.ComponentModel;

public class RuneArgument : INotifyPropertyChanged
{
	private long _Target;

	private List<long> _IDs;

	public virtual long Target
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual List<long> IDs
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
