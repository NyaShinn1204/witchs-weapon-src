using System.Collections.Generic;
using System.ComponentModel;

public class ShopSet : INotifyPropertyChanged
{
	private long _ID;

	private bool _AutoRefresh;

	private bool _ManualRefresh;

	private ShopSetStateEnum _State;

	private int _refreshCount;

	private long _StopTime;

	private int _VipExtra;

	private List<ShopInfo> _Shops;

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

	public virtual bool AutoRefresh
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual bool ManualRefresh
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual ShopSetStateEnum State
	{
		get
		{
			return default(ShopSetStateEnum);
		}
		set
		{
		}
	}

	public virtual int refreshCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual long StopTime
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual int VipExtra
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual List<ShopInfo> Shops
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
