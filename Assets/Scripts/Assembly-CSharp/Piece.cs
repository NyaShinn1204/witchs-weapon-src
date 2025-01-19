using System.ComponentModel;

public class Piece : INotifyPropertyChanged
{
	private long _ID;

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

	public Piece(long id, int num)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
