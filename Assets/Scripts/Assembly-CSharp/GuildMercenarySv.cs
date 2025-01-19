using System.ComponentModel;
using WaterBell.ProjX.Data.Entity;

public class GuildMercenarySv : INotifyPropertyChanged
{
	private long _ID;

	private long _User;

	private int _Level;

	private int _Rank;

	private int _Star;

	private long _AddTime;

	private int _WeaponLevel;

	private long _WeaponCardID;

	private int _WeaponSpellPromoteLv;

	private int _TimeProfit;

	private int _EmployProfit;

	private int _EmployDailyProfit;

	private long _LastEmployTime;

	private int _EmployCount;

	private int _EmployDailyCount;

	private int _Fashion;

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

	public virtual long User
	{
		get
		{
			return 0L;
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

	public virtual long AddTime
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual int WeaponLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

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

	public virtual int WeaponSpellPromoteLv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int TimeProfit
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int EmployProfit
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int EmployDailyProfit
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual long LastEmployTime
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual int EmployCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int EmployDailyCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int Fashion
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string RoleName { get; set; }

	public int WpCurSkin { get; set; }

	public event PropertyChangedEventHandler PropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public GuildMercenarySv(MercenaryServant sv)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
