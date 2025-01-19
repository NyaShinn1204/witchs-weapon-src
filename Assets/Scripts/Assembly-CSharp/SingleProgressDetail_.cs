using System.Collections.Generic;
using System.ComponentModel;

public class SingleProgressDetail_ : INotifyPropertyChanged
{
	private ChapterInfo _chapterInfo;

	private InstanceSet _instanceSet;

	private List<LevelInfo> _levelInfo;

	private List<Instance> _instance;

	public virtual ChapterInfo chapterInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual InstanceSet instanceSet
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual List<LevelInfo> levelInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual List<Instance> instance
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
