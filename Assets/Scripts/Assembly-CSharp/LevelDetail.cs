using System.Collections.Generic;
using System.ComponentModel;

public class LevelDetail : INotifyPropertyChanged
{
	private string _levelID;

	private string _levelName;

	private string _levelDescription;

	private int _stamina;

	private int _instanceEnterLimit;

	private int _battleCount;

	private int _battleCountMax;

	private bool _pass;

	private int _resetCount;

	private int _resetCountMax;

	private List<Enemy> _enemys;

	private List<Loot> _loots;

	public virtual string levelID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string levelName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string levelDescription
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int stamina
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int instanceEnterLimit
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int battleCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int battleCountMax
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual bool pass
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual int resetCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int resetCountMax
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual List<Enemy> enemys
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual List<Loot> loots
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

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
