using System.ComponentModel;

public class ServantClient : INotifyPropertyChanged
{
	private int _ID;

	private int _promotionLevel;

	private int _isShow;

	private int _name;

	private int _talk;

	private string _icon;

	private string _head;

	private string _model;

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

	public virtual int promotionLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int isShow
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int name
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int talk
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual string icon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string head
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string model
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

	public ServantClient()
	{
	}

	public ServantClient(object[] arguments)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
