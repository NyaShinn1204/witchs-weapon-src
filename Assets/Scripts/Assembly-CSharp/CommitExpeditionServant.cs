using System.Collections.Generic;
using System.ComponentModel;

public class CommitExpeditionServant : INotifyPropertyChanged
{
	private List<long> _Servants;

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
