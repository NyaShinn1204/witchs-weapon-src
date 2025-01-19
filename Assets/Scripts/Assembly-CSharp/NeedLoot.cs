using System.ComponentModel;

public class NeedLoot : INotifyPropertyChanged
{
	private Loot _Item;

	private int _NeedNum;

	public virtual Loot Item
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int NeedNum
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

	public NeedLoot()
	{
	}

	public NeedLoot(long itemid, int NeedNum)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
