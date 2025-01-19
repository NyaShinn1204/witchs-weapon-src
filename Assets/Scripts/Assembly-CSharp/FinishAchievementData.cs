using System.ComponentModel;

public class FinishAchievementData : INotifyPropertyChanged
{
	private string _Icon;

	private string _Name;

	private string _ConditionText;

	private string _Text;

	private string _ConditionSprite;

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

	public event PropertyChangedEventHandler PropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public FinishAchievementData()
	{
	}

	public FinishAchievementData(string icon, string name, string condition_text, string text, string condition_sprite)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
