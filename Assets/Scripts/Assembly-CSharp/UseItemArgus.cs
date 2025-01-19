using System.Collections.Generic;
using System.ComponentModel;

public class UseItemArgus : INotifyPropertyChanged
{
	private List<UseItemArgu> _Arugs;

	public virtual List<UseItemArgu> Arugs
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
