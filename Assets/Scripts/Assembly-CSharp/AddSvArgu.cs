using System.Collections.Generic;
using System.ComponentModel;

public class AddSvArgu : INotifyPropertyChanged
{
	private List<long> _Servants;

	private List<long> _Weapons;

	public virtual List<long> Servants
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual List<long> Weapons
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

	public AddSvArgu(List<long> sv, List<long> wp)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
