using System.ComponentModel;

public class ServantLevelInfo : INotifyPropertyChanged
{
	private int _ID;

	private int _levelupExp1;

	private int _levelupExp2;

	private int _levelupExp3;

	private int _levelupExp4;

	private int _levelupExp5;

	private int _levelFavorability;

	private int _spellCost;

	private string _spellFavorability;

	public virtual int ID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int levelupExp1
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int levelupExp2
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int levelupExp3
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int levelupExp4
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int levelupExp5
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int levelFavorability
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int spellCost
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual string spellFavorability
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
