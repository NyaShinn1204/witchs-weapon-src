using System.ComponentModel;

public class ServantWeaponSimpleInfo : INotifyPropertyChanged
{
	private long _WeaponCardID;

	private bool _isUnlock;

	private int _SpellPromoteLv;

	private int _CurrentSkinIndex;

	private int _SkinState;

	public virtual long WeaponCardID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual bool isUnlock
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual int SpellPromoteLv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int CurrentSkinIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SkinState
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

	public ServantWeaponSimpleInfo(long id, int splv, bool unlock, int wpSkins, int wpCurrentSkin)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
