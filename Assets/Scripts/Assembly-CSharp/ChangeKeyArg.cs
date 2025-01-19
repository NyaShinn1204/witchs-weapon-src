using System.Collections.Generic;
using System.ComponentModel;

public class ChangeKeyArg : INotifyPropertyChanged
{
	private long _Target;

	private List<long> _Item;

	private List<int> _Num;

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

	public virtual List<long> Item
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual List<int> Num
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
