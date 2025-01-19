using System.ComponentModel;

public class Instance : INotifyPropertyChanged
{
	private string _ID;

	private string _instanceName;

	private string _instanceDesc;

	private string _instanceIcon;

	private string _instanceSetAttached;

	private int _instanceType;

	private int _instanceSubType;

	private string _instanceMobConfig;

	private string _instanceReward;

	private string _instanceSpecialReward;

	private int _instanceSpecialEnterLevel;

	private int _instanceTimeLimit;

	private int _instanceEnterLevel;

	private int _instanceEnterLimit;

	private string _instanceZone1;

	private string _instanceZone2;

	private string _instanceZone3;

	private int _instanceRepeatable;

	private int _instanceStamina;

	private int _instancePower;

	private string _instanceBuffer1;

	private string _instanceBuffer2;

	private string _instanceBuffer3;

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

	public virtual string instanceName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string instanceDesc
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string instanceIcon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string instanceSetAttached
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int instanceType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int instanceSubType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual string instanceMobConfig
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string instanceReward
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string instanceSpecialReward
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int instanceSpecialEnterLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int instanceTimeLimit
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int instanceEnterLevel
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

	public virtual string instanceZone1
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string instanceZone2
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string instanceZone3
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int instanceRepeatable
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int instanceStamina
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int instancePower
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual string instanceBuffer1
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string instanceBuffer2
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string instanceBuffer3
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
