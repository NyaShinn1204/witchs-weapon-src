using System.ComponentModel;
using WaterBell.ProjX.Data.Entity;

public class Enemy : INotifyPropertyChanged
{
	private string _enemyID;

	private string _icon;

	private int _type;

	public virtual string enemyID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string icon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int type
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

	public Enemy(long ID, string icon, int type)
	{
	}

	public Enemy(ProgressDetail.SingleProgressDetail.InstanceExtension instanceExt, int index)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
