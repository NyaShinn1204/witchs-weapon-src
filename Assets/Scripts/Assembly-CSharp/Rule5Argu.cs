using System.ComponentModel;

public class Rule5Argu : INotifyPropertyChanged
{
	private int _difficult;

	private bool _isspecial;

	private int _moblevel;

	public virtual int difficult
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual bool isspecial
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual int moblevel
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

	public Rule5Argu(int roundType, int moblevel = 0)
	{
	}

	public Rule5Argu(int difficult, bool isSpecial, int moblevel = 0)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
