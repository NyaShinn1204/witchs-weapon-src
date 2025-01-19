using System.ComponentModel;

public class GoodInfo : INotifyPropertyChanged
{
	private long _ID;

	private int _Price;

	private int _Num;

	private int _Discount;

	private bool _IsDiscount;

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

	public virtual int Price
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

	public virtual int Discount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual bool IsDiscount
	{
		get
		{
			return false;
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
