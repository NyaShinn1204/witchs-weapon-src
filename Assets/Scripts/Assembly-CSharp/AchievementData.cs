using System.Collections.Generic;
using System.ComponentModel;

public class AchievementData : INotifyPropertyChanged
{
	private string _Icon;

	private string _Name;

	private int _Limit1;

	private int _Type;

	private string _ConditionText;

	private string _Text;

	private long _Id;

	private string _ConditionSprite;

	private int _Limit2;

	private long _Limit3;

	private int _Status;

	private List<DrawResultData> _Rewards;

	private List<string> _Meta;

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

	public virtual int Limit1
	{
		get
		{
			return 0;
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

	public virtual string ConditionText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual long Id
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual string ConditionSprite
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int Limit2
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual long Limit3
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual int Status
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

	public virtual List<string> Meta
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

	public AchievementData()
	{
	}

	public AchievementData(string icon, string name, List<DrawResultData> rew, int aType, string condition_text, string text, long id, string condition_sprite, int limit1, int limit2, long limit3, List<string> meta, int status)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
