using System.ComponentModel;

public class Spell : INotifyPropertyChanged
{
	private string _SpellID;

	private int _SpellLevel;

	private int _SpellCost;

	private string _SpellName;

	private string _SpellDesc;

	private string _SpellType;

	private string _SpellIcon;

	private string _SpellEffect;

	public virtual string SpellID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int SpellLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SpellCost
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual string SpellName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string SpellDesc
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string SpellType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string SpellIcon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string SpellEffect
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

	public Spell()
	{
	}

	public Spell(long spellID, int lv, int i)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
