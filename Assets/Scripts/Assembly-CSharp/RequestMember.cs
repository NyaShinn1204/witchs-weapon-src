using System.ComponentModel;

public class RequestMember : INotifyPropertyChanged
{
	private long _ID;

	private string _Name;

	private int _Level;

	private double _CombatEffectiveness;

	private long _RemainTime;

	private int _Head;

	private int _HeadBox;

	private int _ServantCount;

	private int _WeaponCount;

	private int _Title;

	public virtual long ID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

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

	public virtual int Level
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual double CombatEffectiveness
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public virtual long RemainTime
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual int Head
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int HeadBox
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int ServantCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int WeaponCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int Title
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

	public RequestMember(long id, string name, int head, int headbox, int level, double ce, long RemainTime, int SvCount, int WeaponCount, int title)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
