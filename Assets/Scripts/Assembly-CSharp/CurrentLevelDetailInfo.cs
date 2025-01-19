using System.Collections.Generic;
using System.ComponentModel;

public class CurrentLevelDetailInfo : INotifyPropertyChanged
{
	private string _LevelName;

	private string _LevelDescription;

	private int _stamina;

	private int _BattleCountMax;

	private List<Enemy> _Enemys;

	private List<Loot> _Loots;

	public virtual string LevelName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string LevelDescription
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int stamina
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int BattleCountMax
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual List<Enemy> Enemys
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual List<Loot> Loots
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

	public CurrentLevelDetailInfo(long lvID)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
