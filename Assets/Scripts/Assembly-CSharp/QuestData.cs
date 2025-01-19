using System.Collections.Generic;
using System.ComponentModel;

public class QuestData : INotifyPropertyChanged
{
	private string _Name;

	private string _Desc;

	private string _DescIcon;

	private string _Tips;

	private string _Icon;

	private int _Argu1;

	private long _Argu2;

	private long _Argu3;

	private int _Type;

	private List<DrawResultData> _Rewards;

	public virtual string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string Desc
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string DescIcon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string Tips
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string Icon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int Argu1
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual long Argu2
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual long Argu3
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual int Type
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual List<DrawResultData> Rewards
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

	public QuestData(long id)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
