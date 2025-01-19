using System.Collections.Generic;
using System.ComponentModel;

public class SweepLoot : INotifyPropertyChanged
{
	private int _Gold;

	private List<DrawResultData> _Loots;

	public virtual int Gold
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual List<DrawResultData> Loots
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
