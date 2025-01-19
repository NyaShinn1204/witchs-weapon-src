using System.ComponentModel;

public class GuildSimple : INotifyPropertyChanged
{
	private string _ID;

	private string _Name;

	private string _Emblem;

	private string _Slogan;

	private int _Count;

	private long _CombatEffectiveness;

	private int _Level;

	private string _PresidentName;

	private int _PresidentLevel;

	private string _EmblemBorder;

	private string _EmblemBackground;

	private int _Buff;

	private int _emblemColor;

	private int _emblemborderColor;

	private int _emblembackgroundColor;

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

	public virtual string Emblem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string Slogan
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int Count
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual long CombatEffectiveness
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

	public virtual string PresidentName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int PresidentLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual string EmblemBorder
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string EmblemBackground
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int Buff
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int emblemColor
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int emblemborderColor
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int emblembackgroundColor
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public long RequestTime { get; set; }

	public event PropertyChangedEventHandler PropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public GuildSimple(string id, string name, long Emblem, long EmblemBackground, long EmblemBorder, int EmblemColor, int EmblemBackgroundColor, int EmblemBorderColor, string slogan, int count, long ce, int lv, string presidentName, int presidentLv, long time = 0L, int buff = 0)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
