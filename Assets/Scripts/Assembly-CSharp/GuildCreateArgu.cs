using System.ComponentModel;

public class GuildCreateArgu : INotifyPropertyChanged
{
	private string _Name;

	private string _Logo;

	private string _Slogan;

	private long _emblem;

	private long _emblemborder;

	private long _emblembackground;

	private int _emblemColor;

	private int _emblemborderColor;

	private int _emblembackgroundColor;

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

	public virtual string Logo
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

	public virtual long emblem
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual long emblemborder
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual long emblembackground
	{
		get
		{
			return 0L;
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
