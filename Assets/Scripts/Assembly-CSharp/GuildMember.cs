using System.ComponentModel;

public class GuildMember : INotifyPropertyChanged
{
	private long _ID;

	private string _Name;

	private int _Level;

	private double _CombatEffectiveness;

	private long _LastTime;

	private int _Privilege;

	private long _EnterTime;

	private int _TotalVitality;

	private int _DailyVitality;

	private int _Head;

	private int _HeadBox;

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

	public virtual long LastTime
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual int Privilege
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual long EnterTime
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual int TotalVitality
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int DailyVitality
	{
		get
		{
			return 0;
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

	public GuildMember(long id, string name, int head, int headBox, int level, double ce, long lastTime, int privilege, long enterTime, int vitalityTotal, int vitalityDaily, int title)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
