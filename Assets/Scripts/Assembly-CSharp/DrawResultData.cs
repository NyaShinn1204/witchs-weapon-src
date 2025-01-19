using System.Collections.Generic;
using System.ComponentModel;

public class DrawResultData : INotifyPropertyChanged
{
	private int _LootType;

	private int _Num;

	private long _LootID;

	private bool _isFirstGet;

	private long _Value;

	private List<Piece> _Pieces;

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

	public virtual long LootID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual bool isFirstGet
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual long Value
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual List<Piece> Pieces
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool HaveKnifeStone { get; set; }

	public event PropertyChangedEventHandler PropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public DrawResultData(GlobalEnum.ResType resType, long lootID, long value, int num, bool firstGet, List<Piece> pieces, bool haveKnifeStone = false)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
