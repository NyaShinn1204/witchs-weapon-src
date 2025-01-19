using System.Collections.Generic;
using System.ComponentModel;

public class SweepInfo : INotifyPropertyChanged
{
	private int _SweepBeforeLv;

	private int _SweepAfterLv;

	private int _StaminaBefore;

	private int _StaminaAfter;

	private List<SweepLoot> _Loots;

	public virtual int SweepBeforeLv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SweepAfterLv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int StaminaBefore
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int StaminaAfter
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual List<SweepLoot> Loots
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
