using System.ComponentModel;

public class ServantListItemInfo : INotifyPropertyChanged
{
	private string _Name;

	private string _Icon;

	private int _WeaponType;

	private string _Head;

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

	public virtual string Icon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int WeaponType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual string Head
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

	public ServantListItemInfo(long servantID)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
