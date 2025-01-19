using System.ComponentModel;

public class UseItemArgu : INotifyPropertyChanged
{
	private long _ID;

	private int _Num;

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

	public virtual int Num
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Exp { get; set; }

	public event PropertyChangedEventHandler PropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public UseItemArgu(long id, int num)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
