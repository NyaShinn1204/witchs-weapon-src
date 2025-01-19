using System.ComponentModel;

public class BuyGoodArug : INotifyPropertyChanged
{
	private long _SetID;

	private long _ShopID;

	private long _GoodID;

	private int _Num;

	private int _PayType;

	public virtual long SetID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual long ShopID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual long GoodID
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

	public virtual int PayType
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

	public BuyGoodArug(long setId, long shopId, long goodId, int num, int payType = 1)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
