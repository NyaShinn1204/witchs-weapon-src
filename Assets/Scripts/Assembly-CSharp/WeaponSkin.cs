using System.ComponentModel;

public class WeaponSkin : INotifyPropertyChanged
{
	private int _WeaponIndex;

	private bool _IsUnlock;

	public virtual int WeaponIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual bool IsUnlock
	{
		get
		{
			return false;
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

	public WeaponSkin(int weaponIndex, bool isUnlock)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
