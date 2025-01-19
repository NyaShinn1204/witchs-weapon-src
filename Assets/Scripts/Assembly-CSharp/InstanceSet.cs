using System.ComponentModel;

public class InstanceSet : INotifyPropertyChanged
{
	private string _ID;

	private string _instanceSetName;

	private string _instanceSetDesc;

	private string _instanceSetIcon;

	private string _instanceSetImage;

	private int _instanceSetType;

	private string _instanceSetNext;

	private int _instanceSetEnterLimit;

	private int _instanceSetEnterLevel;

	private int _instanceSetSweepLevel;

	private string _firstInstance;

	private string _frontInstance;

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

	public virtual string instanceSetName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string instanceSetDesc
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string instanceSetIcon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string instanceSetImage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int instanceSetType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual string instanceSetNext
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int instanceSetEnterLimit
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int instanceSetEnterLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int instanceSetSweepLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual string firstInstance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string frontInstance
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

	public InstanceSet()
	{
	}

	public InstanceSet(object[] arguments)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
