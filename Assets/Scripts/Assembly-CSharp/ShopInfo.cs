using System.Collections.Generic;
using System.ComponentModel;

public class ShopInfo : INotifyPropertyChanged
{
	private long _ID;

	private List<GoodInfo> _AllGoods;

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

	public virtual List<GoodInfo> AllGoods
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int RemainNum { get; set; }

	public int MaxNum { get; set; }

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
