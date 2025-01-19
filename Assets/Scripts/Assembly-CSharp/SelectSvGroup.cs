using System.Collections.Generic;
using System.ComponentModel;

public class SelectSvGroup : INotifyPropertyChanged
{
	private int _Mode;

	private List<HireArgu> _Sv;

	public virtual int Mode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual List<HireArgu> Sv
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

	public SelectSvGroup(int mode, List<HireArgu> sv)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
