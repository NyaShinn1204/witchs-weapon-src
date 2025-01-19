using System.ComponentModel;

public class LootResult : INotifyPropertyChanged
{
	private long _ID;

	private int _LootType;

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

	public virtual int LootType
	{
		get
		{
			return 0;
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

	public event PropertyChangedEventHandler PropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public LootResult(long id, int type, int num)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
