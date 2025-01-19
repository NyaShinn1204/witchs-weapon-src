using System.ComponentModel;

public class LevelInfo : INotifyPropertyChanged
{
	private string _ID;

	private bool _pass;

	private int _stars;

	private int _battleCount;

	private string _resetCount;

	public virtual string ID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual bool pass
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual int stars
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int battleCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual string resetCount
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
