using System.ComponentModel;

public class ServantMainInfo : INotifyPropertyChanged
{
	private string _Name;

	private string _WeapoType;

	private int _Rank;

	private int _Star;

	private int _Fav;

	public virtual string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string WeapoType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int Rank
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int Star
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int Fav
	{
		get
		{
			return 0;
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
