using System.ComponentModel;

public class RewardData : INotifyPropertyChanged
{
	private int _SpriteType;

	private int _value;

	private string _Sprite;

	private long _Id;

	public virtual int SpriteType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int value
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual string Sprite
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual long Id
	{
		get
		{
			return 0L;
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

	public RewardData()
	{
	}

	public RewardData(int Type, int Value, long id = 0L)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
