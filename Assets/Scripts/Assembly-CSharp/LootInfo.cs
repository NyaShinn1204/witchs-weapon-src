using System.ComponentModel;
using Lootmod;

public class LootInfo : INotifyPropertyChanged
{
	private long _Num;

	private Loot _Loot;

	public virtual long Num
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual Loot Loot
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

	public LootInfo(LootObject info)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
