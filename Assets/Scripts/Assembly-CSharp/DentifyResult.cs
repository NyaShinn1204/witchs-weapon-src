using System.Collections.Generic;
using System.ComponentModel;

public class DentifyResult : INotifyPropertyChanged
{
	private long suitId;

	private List<int> randomAttrTypes;

	private List<int> randomAttrValues;

	public long SuitId
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public List<int> RandomAttrTypes
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<int> RandomAttrValues
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
